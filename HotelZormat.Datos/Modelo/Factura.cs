// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;

namespace HotelZormat.Negocio.Modelo
{
    public class Factura
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public string NCF { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ITBIS { get; set; }
        public decimal PropinaLegal { get; set; }
        public decimal Total { get; set; }
    }
}
