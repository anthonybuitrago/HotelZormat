// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;

namespace HotelZormat.Negocio.Excepciones
{
        // TODO: RUBRICA - Mínimo 1 excepción personalizada de negocio
public class HabitacionOcupadaException : Exception
    {
        public int NumeroHabitacion { get; private set; }

        public HabitacionOcupadaException(int numeroHabitacion)
            : base("La habitación número " + numeroHabitacion + " ya se encuentra ocupada o en mantenimiento.")
        {
            NumeroHabitacion = numeroHabitacion;
        }
    }
}

