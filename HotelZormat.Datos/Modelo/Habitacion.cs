// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
namespace HotelZormat.Negocio.Modelo
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Piso { get; set; }
        public string Estado { get; set; }
        public int Capacidad { get; set; }
        public decimal TarifaBase { get; set; }
    }
}
