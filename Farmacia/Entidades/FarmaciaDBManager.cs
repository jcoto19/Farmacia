using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


namespace Farmacia.Entidades
{
    
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public string DNICliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public double DescuentoTerceraEdad { get; set; }
        public double Descuento { get; set; }
        public double TotalDescuento { get; set; }
        public double TotalFactura { get; set; }
        public double Subtotal { get; set; }
    }

    public class DetalleFactura
    {
        public int Id { get; set; }
        public int NumeroFactura { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
    public class Cliente
    {
        [Key]
        public string DNI { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
    }


    public class FarmaciaDBManager
    {
        
        private string connectionString;

        public FarmaciaDBManager(string dbFileName)
        {
            string dbPath = Path.Combine(Application.StartupPath, dbFileName);
            connectionString = $"Data Source={dbPath};Version=3;";
            //CrearTablaClientes();
            //BorrarBaseDeDatos(dbPath);
        }

        public void AgregarMedicamento(string id, string nombre, string descripcion, int cantidad, double precio, string fecha)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Medicamentos (Id, Nombre, Descripcion, Cantidad, PrecioUnitario, FechaIngreso) " +
                               "VALUES (@Id, @Nombre, @Descripcion, @Cantidad, @PrecioUnitario, @FechaIngreso)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@PrecioUnitario", precio);
                    command.Parameters.AddWithValue("@FechaIngreso", fecha);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void CrearTablaClientes()
        {
            // Verificar si la tabla ya existe
            string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='Clientes'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    // Si el resultado no es nulo, significa que la tabla ya existe
                    if (result != null)
                        return; // No es necesario crear la tabla, salir del método
                }
            }

            // Si la tabla no existe, crearla
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Clientes (
                            DNI TEXT PRIMARY KEY,
                            Nombre TEXT,
                            Direccion TEXT,
                            Telefono TEXT,
                            Email TEXT
                        )";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AgregarFactura(Factura factura)
        {
            string query = @"INSERT INTO Factura (DNICliente, Nombre, Telefono, DescuentoTerceraEdad, Descuento, TotalDescuento, TotalFactura, Subtotal)
                             VALUES (@DNICliente, @Nombre, @Telefono, @DescuentoTerceraEdad, @Descuento, @TotalDescuento, @TotalFactura, @Subtotal)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNICliente", factura.DNICliente);
                    command.Parameters.AddWithValue("@Nombre", factura.Nombre);
                    command.Parameters.AddWithValue("@Telefono", factura.Telefono);
                    command.Parameters.AddWithValue("@DescuentoTerceraEdad", factura.DescuentoTerceraEdad);
                    command.Parameters.AddWithValue("@Descuento", factura.Descuento);
                    command.Parameters.AddWithValue("@TotalDescuento", factura.TotalDescuento);
                    command.Parameters.AddWithValue("@TotalFactura", factura.TotalFactura);
                    command.Parameters.AddWithValue("@Subtotal", factura.Subtotal);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AgregarCliente(Cliente cliente)
        {
            if (!TablaClientesExiste())
            {
                // La tabla de clientes no existe, puedes mostrar un mensaje de error o lanzar una excepción
                throw new Exception("La tabla de clientes no existe en la base de datos.");
            }
            string query = @"INSERT INTO Clientes (DNI, Nombre, Direccion, Telefono, Email)
                     VALUES (@DNI, @Nombre, @Direccion, @Telefono, @Email)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI", cliente.DNI);
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@Email", cliente.Email);

                    command.ExecuteNonQuery();
                }
            }
        }
        private bool TablaClientesExiste()
        {
            string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='Clientes'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result != null; // Devuelve true si la tabla existe, false si no existe
                }
            }
        }

        public void AgregarDetalleFactura(DetalleFactura detalle)
        {
            string query = @"INSERT INTO DetalleFactura (NumeroFactura, IdProducto, Cantidad)
                             VALUES (@NumeroFactura, @IdProducto, @Cantidad)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeroFactura", detalle.NumeroFactura);
                    command.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
                    command.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void BorrarBaseDeDatos(string dbPath)
        {
            try
            {
                if (File.Exists(dbPath))
                {
                    File.Delete(dbPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    public class Medicamento
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public DateTime FechaIngreso { get; set; }
    }

    
}

