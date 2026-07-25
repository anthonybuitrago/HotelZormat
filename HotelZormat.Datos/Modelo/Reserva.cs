// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;

namespace HotelZormat.Negocio.Modelo
{
    public class Reserva
    {
        public int Id { get; set; }
        public int HuespedId { get; set; }
        public int HabitacionId { get; set; }
        public DateTime FechaCheckIn { get; set; }
        public DateTime FechaCheckOut { get; set; }
        public string Temporada { get; set; }
        public string Estado { get; set; }
        public int TotalNoches { get; set; }
        public decimal MontoTotal { get; set; }

        public string NombreHuesped { get; set; }
        public int NumeroHabitacion { get; set; }
    }
}
