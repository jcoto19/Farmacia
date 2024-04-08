using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmacia.Entidades
{
    internal class ConexionSQLite
    {
        private SQLiteConnection conexion;

        public ConexionSQLite(string connectionString)
        {
            conexion = new SQLiteConnection(connectionString);
        }

        public void AbrirConexion()
        {
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        public SQLiteConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
