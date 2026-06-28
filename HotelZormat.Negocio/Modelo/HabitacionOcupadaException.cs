using System;

namespace HotelZormat.Negocio.Modelo
{
    public class HabitacionOcupadaException : Exception
    {
        public int NumeroHabitacion { get; }

        public HabitacionOcupadaException(int numeroHabitacion) 
            : base($"La habitación {numeroHabitacion} ya se encuentra ocupada.")
        {
            NumeroHabitacion = numeroHabitacion;
        }
    }
}
