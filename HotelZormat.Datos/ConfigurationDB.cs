using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelZormat.Datos
{
    public static class ConfigurationDB
    {
        public static string ObtenerConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HotelZormatDB"].ConnectionString;
        }
    }
}
