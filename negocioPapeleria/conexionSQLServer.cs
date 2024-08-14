using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocioPapeleria
{
    internal class conexionSQLServer
    {

        private SqlConnection conexion;
        private string cadenaConexion = "Server=WIN-BELB5I9714N;Database=Tienda_MarujaQuito;User Id=sa;Password=P@ssw0rd;";

        public conexionSQLServer()
        {
            // Inicializa la conexión
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection GetConnection()
        {
            return conexion;
        }

        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión establecida correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
            }
        }
    }
}
