// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;

namespace HotelZormat.Negocio.Modelo
{
    public class ReservaInvalidaException : Exception
    {
        public string Motivo { get; private set; }

        public ReservaInvalidaException(string motivo)
            : base("Reserva no válida: " + motivo)
        {
            Motivo = motivo;
        }
    }
}
