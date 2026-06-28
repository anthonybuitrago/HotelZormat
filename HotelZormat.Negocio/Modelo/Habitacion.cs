using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Modelo
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Piso { get; set; }
        public int Capacidad { get; set; }
        public int TarifaBase { get; set; }
        public string Estado { get; set; }

        public bool EstaDisponible()
        {
            return Estado == "Disponible";
        }
    }
}
