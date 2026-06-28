using System;
using System.Collections.Generic;
using System.Linq;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class HabitacionServicio
    {
        private List<Habitacion> _habitaciones;

        public HabitacionServicio()
        {
            _habitaciones = new List<Habitacion>
            {
                new Habitacion { Id = 1, Numero = 101, Tipo = "Sencilla", Piso = "1", Estado = "Disponible" },
                new Habitacion { Id = 2, Numero = 201, Tipo = "Doble", Piso = "2", Estado = "Ocupada" },
                new Habitacion { Id = 3, Numero = 301, Tipo = "Sencilla", Piso = "3", Estado = "Disponible" },
                new Habitacion { Id = 4, Numero = 302, Tipo = "Doble", Piso = "3", Estado = "Ocupada" },
                new Habitacion { Id = 5, Numero = 303, Tipo = "Suite", Piso = "3", Estado = "Mantenimiento" },
                new Habitacion { Id = 6, Numero = 304, Tipo = "Sencilla", Piso = "3", Estado = "Limpieza" }
            };
        }

        public List<Habitacion> ObtenerTodas()
        {
            return _habitaciones;
        }

        public Habitacion ObtenerPorNumero(int numero)
        {
            var habitacion = _habitaciones.FirstOrDefault(h => h.Numero == numero);
            if (habitacion == null)
            {
                throw new Exception($"La habitación {numero} no existe.");
            }
            return habitacion;
        }

        public void GuardarHabitacion(Habitacion habitacion)
        {
            var existente = ObtenerPorNumero(habitacion.Numero);
            if (existente.Estado == "Ocupada" && habitacion.Estado == "Ocupada")
            {
                throw new HabitacionOcupadaException(habitacion.Numero);
            }
            existente.Estado = habitacion.Estado;
        }
    }
}
