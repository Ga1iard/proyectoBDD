using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace negocioPapeleria
{
    internal class conexionPostgres
    {

        private NpgsqlConnection conexion;
        private string cadenaConexion = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=negocio";

        public conexionPostgres()
        {
            // Inicializa la conexión
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public NpgsqlConnection GetConnection()
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
