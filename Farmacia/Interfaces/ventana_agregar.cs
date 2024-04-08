using Farmacia.Entidades;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class ventana_agregar : Form
    {
        private FarmaciaDBManager dbManager;
        private string dbFileName = "farmacia_db.db";
        private string connectionString;

        public ventana_agregar()
        {
            InitializeComponent();
            // Asignar la cadena de conexión correctamente
            string dbPath = Path.Combine(Application.StartupPath, dbFileName);
            connectionString = $"Data Source={dbPath};Version=3;";
            dbManager = new FarmaciaDBManager(connectionString); // Utilizar la cadena de conexión en el constructor
            /*dgv_Clientes.Columns.Add("DNI", "DNI");
            dgv_Clientes.Columns.Add("Nombre", "Nombre");
            dgv_Clientes.Columns.Add("Direccion", "Direccion");
            dgv_Clientes.Columns.Add("Telefono", "Telefono");
            dgv_Clientes.Columns.Add("Email", "Email");
            */

            try
            {
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void MostrarDatos()
        {
            string query = "SELECT * FROM Clientes";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_Clientes.DataSource = dataTable;
                }
            }
        }

        private void bt_guardarCliente_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrEmpty(txt_dni.Text) || string.IsNullOrEmpty(txt_nombre.Text) ||
                string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_telefono.Text) ||
                string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                FarmaciaDBManager dbManager = new FarmaciaDBManager("farmacia_db.db");
                // Obtener los datos del nuevo cliente desde los controles
                string dni = txt_dni.Text;
                string nombre = txt_nombre.Text;
                string direccion = txt_direccion.Text;
                string telefono = txt_telefono.Text;
                string email = txt_email.Text;

                // Agregar el nuevo cliente a la base de datos
                dbManager.AgregarCliente(new Cliente
                {
                    DNI = dni,
                    Nombre = nombre,
                    Direccion = direccion,
                    Telefono = telefono,
                    Email = email
                });

                // Limpiar los controles después de agregar el cliente
                LimpiarCampos();

                // Actualizar la tabla de clientes
                MostrarDatos();

                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_dni.Text = "";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}