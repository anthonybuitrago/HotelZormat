// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Conexion
{
    public static class ConexionBD
    {
        public static string ObtenerConnectionString()
        {
            var connStr =             // TODO: RUBRICA - Connection string en App.config sin hardcodear
ConfigurationManager.ConnectionStrings["HotelZormatDB"];
            if (connStr == null || string.IsNullOrWhiteSpace(connStr.ConnectionString))
            {
                throw new ConfigurationErrorsException("La cadena de conexión 'HotelZormatDB' no se encontró en App.config.");
            }
            return connStr.ConnectionString;
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ObtenerConnectionString());
        }
    }
}
