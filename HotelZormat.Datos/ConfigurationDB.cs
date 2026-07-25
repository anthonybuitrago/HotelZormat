// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Configuration;

namespace HotelZormat.Datos
{
    public static class ConfigurationDB
    {
        public static string ObtenerConnectionString()
        {
            var connStr = ConfigurationManager.ConnectionStrings["HotelZormatDB"];
            if (connStr == null || string.IsNullOrWhiteSpace(connStr.ConnectionString))
            {
                return "Data Source=localhost\\SQLEXPRESS;Initial Catalog=HotelZormatDB;Integrated Security=True;";
            }
            return connStr.ConnectionString;
        }
    }
}
