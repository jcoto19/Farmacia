using Farmacia.Entidades;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Farmacia.ventana_ventas;

namespace Farmacia
{
    public partial class ventana_farmacia : Form
    {
        private string dbFileName = "farmacia_db.db";
        private string connectionString;

        private ventana_ventas ventanaVentas;

        public ventana_farmacia()
        {
            
            InitializeComponent();
            string dbPath = Path.Combine(Application.StartupPath, dbFileName);
            connectionString = $"Data Source={dbPath};Version=3;";
            InitializeDatabase();

            //MessageBox.Show("Antes de CrearTablaClientes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CrearTablaClientes();
            MostrarDatos();
            FarmaciaDBManager dbManager = new FarmaciaDBManager("farmacia_db.db");
            

            dgv_Carrito.Columns.Add("Id", "ID");
            dgv_Carrito.Columns.Add("Nombre", "Nombre");            
            dgv_Carrito.Columns.Add("Cantidad", "Cantidad");
            dgv_Carrito.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgv_Carrito.Columns.Add("Total", "Total");
           
            
            

        }

        private void InitializeDatabase()
        {
            string dbPath = Path.Combine(Application.StartupPath, dbFileName);

            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Crear la tabla de Medicamentos si no existe
                    string createMedicamentosTableQuery = "CREATE TABLE IF NOT EXISTS Medicamentos (Id TEXT PRIMARY KEY, Nombre TEXT, Descripcion TEXT, Cantidad INTEGER, PrecioUnitario REAL, FechaIngreso TEXT, PrecioTotal REAL)";
                    SQLiteCommand createMedicamentosTableCommand = new SQLiteCommand(createMedicamentosTableQuery, connection);
                    createMedicamentosTableCommand.ExecuteNonQuery();
                                       
                }
            }
        }

        private void CrearTablaClientes()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Verificar si la tabla de Clientes ya existe
                    string checkClientesTableQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='Clientes'";
                    SQLiteCommand checkClientesTableCommand = new SQLiteCommand(checkClientesTableQuery, connection);
                    object clientesTableResult = checkClientesTableCommand.ExecuteScalar();

                    // Si la tabla de Clientes no existe, la creamos
                    if (clientesTableResult == null)
                    {
                        string createClientesTableQuery = "CREATE TABLE Clientes (DNI TEXT PRIMARY KEY, Nombre TEXT, Direccion TEXT, Telefono TEXT, Email TEXT)";
                        SQLiteCommand createClientesTableCommand = new SQLiteCommand(createClientesTableQuery, connection);
                        createClientesTableCommand.ExecuteNonQuery();

                        MessageBox.Show("La tabla de Clientes se ha creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tabla de Clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarDatos()
        {
            
            string query = "SELECT * FROM Medicamentos";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    tb_medicamentos.DataSource = dataTable;
                }
            }
        }


        private void bt_agregarNuevo_Click(object sender, EventArgs e)
        {
                // Verificar que todos los campos estén llenos
                if (string.IsNullOrEmpty(txt_id.Text) || string.IsNullOrEmpty(txt_Nombre.Text) ||
                string.IsNullOrEmpty(txt_cantidad.Text) || string.IsNullOrEmpty(txt_precio.Text) ||
                string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un nuevo medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                FarmaciaDBManager dbManager = new FarmaciaDBManager("farmacia_db.db");

                // Obtener los datos del nuevo medicamento desde los controles
                string id = txt_id.Text;
                string nombre = txt_Nombre.Text;
                string descripcion = txt_descripcion.Text;
                int cantidad = int.Parse(txt_cantidad.Text);
                double precio = double.Parse(txt_precio.Text);
                string fecha = dt_fechaIngreso.Value.ToString("yyyy-MM-dd"); // Obtener la fecha del DateTimePicker

                // Agregar el nuevo medicamento a la base de datos
                dbManager.AgregarMedicamento(id, nombre, descripcion, cantidad, precio, fecha);

                // Limpiar los controles después de agregar el medicamento
                limpiarCampos();

                // Actualizar la tabla de medicamentos (si es necesario)
                MostrarDatos(); // Agregar esta línea para actualizar el DataGridView

                MessageBox.Show("Medicamento agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Agregar un TextBox para ingresar el nombre del medicamento a buscar
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string nombreMedicamento = txt_Buscar.Text.Trim();
            BuscarMedicamentoPorNombre(nombreMedicamento);
        }

        private void BuscarMedicamentoPorNombre(string nombre)
        {
            // Realizar la consulta a la base de datos para obtener los medicamentos con el nombre proporcionado
            string query = "SELECT * FROM Medicamentos WHERE Nombre LIKE @Nombre";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%"); // Usar el comodín % para buscar coincidencias parciales

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Limpiar los datos existentes en el DataGridView
                        tb_medicamentos.DataSource = null;

                        // Actualizar la fuente de datos del DataGridView con los resultados de la consulta
                        tb_medicamentos.DataSource = dataTable;
                    }
                }
            }
        }

        private List<MedicamentoEnCarrito> carrito = new List<MedicamentoEnCarrito>();

        private void btn_carrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventanaVentas == null || ventanaVentas.IsDisposed)
                {
                    // Crear una nueva instancia de la ventana de ventas solo si no está creada o está cerrada
                    ventanaVentas = new ventana_ventas(this);
                    ventanaVentas.CarritoActualizado += Farmacia_CarritoActualizado; // Suscribirse al evento CarritoActualizado
                }
                // Obtener el medicamento seleccionado en la tabla
                if (tb_medicamentos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = tb_medicamentos.SelectedRows[0];

                    string idMedicamento = filaSeleccionada.Cells["Id"].Value.ToString();
                    string nombreMedicamento = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    //double Total = 0;
                    // Obtener la cantidad deseada del usuario
                    int cantidadDeseada = ObtenerCantidadDeseada();

                    // Verificar si la cantidad deseada es mayor que la disponible en la base de datos
                    int cantidadDisponible = ObtenerCantidadDisponible(idMedicamento);
                    if (cantidadDeseada > cantidadDisponible)
                    {
                        MessageBox.Show("La cantidad deseada es mayor que la cantidad disponible en el inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Obtener el precio unitario del medicamento
                    double precioUnitario = ObtenerPrecioUnitario(idMedicamento);

                    // Calcular el precio total
                    double Total = precioUnitario * cantidadDeseada;

                    // Agregar el medicamento al carrito
                    MedicamentoEnCarrito nuevoMedicamento = new MedicamentoEnCarrito(idMedicamento, nombreMedicamento, cantidadDeseada, precioUnitario, Total);
                    carrito.Add(nuevoMedicamento);
                    
                    // Verificar si se agregó correctamente
                    if (carrito.Contains(nuevoMedicamento))
                    {
                        MessageBox.Show("El medicamento se agregó correctamente al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al agregar el medicamento al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    /* Imprimir los valores de la lista carrito para verificar
                    string mensaje = "Contenido de la lista carrito:\n";
                    foreach (var item in carrito)
                    {
                        mensaje += $"ID: {item.Id}, Nombre: {item.Nombre}, Cantidad: {item.Cantidad}, Precio Unitario: {item.PrecioUnitario}, Total: {item.Total}\n";
                    }
                    MessageBox.Show(mensaje, "Contenido de la lista carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    // Actualizar la interfaz de usuario para mostrar el contenido del carrito
                    
                    ActualizarInterfazCarrito();
                    
                    OnCarritoActualizado(carrito);
                    //ventanaVentas.MostrarCarrito(carrito);
                }
                else
                {
                    MessageBox.Show("Seleccione un medicamento de la tabla para agregar al carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el medicamento al carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int SolicitarCantidad()
        {
            int cantidad = 0;

            // Mostrar un cuadro de diálogo de entrada para que el usuario ingrese la cantidad deseada
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad deseada:", "Cantidad", "1");

            // Intentar convertir la entrada del usuario a un número entero
            if (!int.TryParse(input, out cantidad))
            {
                MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cantidad;
        }

        
        private int ObtenerCantidadDisponible(string idMedicamento)
        {
            int cantidadDisponible = 0;

            try
            {
                string query = "SELECT Cantidad FROM Medicamentos WHERE Id = @Id";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idMedicamento);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            cantidadDisponible = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al obtener la cantidad disponible: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cantidadDisponible;
        }

        private double ObtenerPrecioUnitario(string idMedicamento)
        {
            double precioUnitario = 0.0; // Puedes inicializar el precio unitario con un valor predeterminado
           
            string query = "SELECT PrecioUnitario FROM Medicamentos WHERE Id = @Id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idMedicamento);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        precioUnitario = Convert.ToDouble(result);
                    }
                }
            }

            return precioUnitario;
        }

        private int ObtenerCantidadDeseada()
        {
            int cantidadDeseada = 0;

            // Creamos un nuevo formulario para solicitar la cantidad deseada al usuario
            Form inputForm = new Form();
            inputForm.Text = "Ingrese la cantidad deseada";
            inputForm.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            inputForm.ControlBox = false; // Ocultar la barra de título con los botones de cerrar y maximizar

            Label label = new Label();
            label.Text = "Cantidad:";
            label.Dock = DockStyle.Top;

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Minimum = 1;
            numericUpDown.Maximum = 1000;
            numericUpDown.Dock = DockStyle.Top;

            Button confirmButton = new Button();
            confirmButton.Text = "Aceptar";
            confirmButton.DialogResult = DialogResult.OK;
            confirmButton.Dock = DockStyle.Bottom;

            inputForm.Controls.AddRange(new Control[] { numericUpDown, label, confirmButton });

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                cantidadDeseada = (int)numericUpDown.Value;
            }

            return cantidadDeseada;
        }

        public class MedicamentoEnCarrito
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double PrecioUnitario { get; set; }
            public double Total { get; set; }

            public MedicamentoEnCarrito(string id, string nombre, int cantidad, double precioUnitario, double total)
            {
                Id = id;
                Nombre = nombre;
                Cantidad = cantidad;
                PrecioUnitario = precioUnitario;
                Total = total; // Aquí asignamos el parámetro 'total' a la propiedad 'Total'
            }
        }

        private int ObtenerCantidadDeseada(string mensaje)
        {
            // Mostrar un MessageBox con un TextBox para que el usuario ingrese la cantidad deseada
            string input = Microsoft.VisualBasic.Interaction.InputBox(mensaje, "Cantidad deseada");
            int cantidadDeseada;

            if (int.TryParse(input, out cantidadDeseada))
            {
                return cantidadDeseada;
            }
            else
            {
                // Manejar el caso en que el usuario ingresa un valor no válido
                // Por ejemplo, mostrar un mensaje de error y devolver un valor predeterminado
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Valor predeterminado indicando un error
            }
        }

        private void ActualizarInterfazCarrito()
        {
            // Limpiar la tabla de carrito
            dgv_Carrito.Rows.Clear();

            // Agregar cada medicamento en el carrito a la tabla
            foreach (MedicamentoEnCarrito item in carrito)
            {
                dgv_Carrito.Rows.Add(item.Id, item.Nombre, item.Cantidad, item.PrecioUnitario, item.Total);
            }
            
        }             
               

        private void limpiarCampos()
        {
            // Limpia los campos de texto y otros controles
            txt_id.Text = "";
            txt_Nombre.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
            txt_precio.Text = "";
            dt_fechaIngreso.Value = DateTime.Now; // Asigna la fecha actual al DateTimePicker
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_borrarCarrito_Click(object sender, EventArgs e)
        {
            // Eliminar todas las filas de la tabla del carrito
            dgv_Carrito.Rows.Clear();

            // Reiniciar la lista de medicamentos en el carrito
            carrito.Clear();
        }

        private void bt_eliminarCarrito_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en la tabla de carrito
            if (dgv_Carrito.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgv_Carrito.SelectedRows[0].Index;

                // Remover el elemento correspondiente de la lista carrito
                carrito.RemoveAt(rowIndex);

                // Actualizar la interfaz de usuario para reflejar los cambios
                ActualizarInterfazCarrito();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la tabla de carrito para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Declaración de un evento para notificar a otros formularios cuando se actualizan los datos del carrito
        public event EventHandler<CarritoActualizadoEventArgs> CarritoActualizado;

        // Método para invocar el evento cuando se actualizan los datos del carrito
        protected virtual void OnCarritoActualizado(List<MedicamentoEnCarrito> carrito)
        {
            CarritoActualizado?.Invoke(this, new CarritoActualizadoEventArgs(carrito));
        }
        private void Farmacia_CarritoActualizado(object sender, CarritoActualizadoEventArgs e)
        {
            // Aquí puedes manejar la lógica para actualizar el carrito en la ventana de farmacia
            // Por ejemplo, puedes actualizar la interfaz de usuario para reflejar los cambios en el carrito
            // Puedes acceder a la lista actualizada de medicamentos en el carrito a través de e.CarritoActualizado
            // Y luego actualizar la interfaz de usuario en consecuencia
            ActualizarInterfazCarrito();
        }

        private void bt_venta_Click(object sender, EventArgs e)
        {
            // Verificar si la ventana de ventas ya está creada
            if (ventanaVentas == null || ventanaVentas.IsDisposed)
            {
                // Crear una nueva instancia de la ventana de ventas solo si no está creada o está cerrada
                ventanaVentas = new ventana_ventas(this);
                ventanaVentas.CarritoActualizado += Farmacia_CarritoActualizado; // Suscribirse al evento CarritoActualizado
            }

            // Mostrar la ventana de ventas
            ventanaVentas.Show();
        }

        private void bt_agregarCliente_Click(object sender, EventArgs e)
        {
            ventana_agregar ventanaAgregar = new ventana_agregar();
            ventanaAgregar.ShowDialog(); // Abre ventana_agregar como un diálogo

        }
    }
}
