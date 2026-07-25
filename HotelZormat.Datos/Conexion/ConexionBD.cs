// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Conexion
{
    public static class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadenaConexion = ConfigurationDB.ObtenerConnectionString();
            return new SqlConnection(cadenaConexion);
        }
    }
}
