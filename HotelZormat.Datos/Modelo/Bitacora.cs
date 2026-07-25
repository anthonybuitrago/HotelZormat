// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;

namespace HotelZormat.Negocio.Modelo
{
    public class Bitacora
    {
        public int Id { get; set; }
        public string UsuarioNombre { get; set; }
        public string Accion { get; set; }
        public DateTime FechaHora { get; set; }
        public string Detalles { get; set; }
    }
}
