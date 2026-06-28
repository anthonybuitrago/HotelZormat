using System;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicio = new ReservaServicio();

            Console.WriteLine("--- RETO 01: ValidarTipoHabitacion ---");
            Console.WriteLine("Suite     → " + servicio.ValidarTipoHabitacion("Suite"));
            Console.WriteLine("Sencilla  → " + servicio.ValidarTipoHabitacion("Sencilla"));
            Console.WriteLine("Penthouse → " + servicio.ValidarTipoHabitacion("Penthouse"));
            Console.WriteLine("(vacío)   → " + servicio.ValidarTipoHabitacion(""));
            Console.WriteLine("(null)    → " + servicio.ValidarTipoHabitacion(null));


        }
    }
}