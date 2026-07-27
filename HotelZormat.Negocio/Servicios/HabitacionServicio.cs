// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class HabitacionServicio
    {
        private readonly HabitacionRepository _repo;

        public HabitacionServicio()
        {
            _repo = new HabitacionRepository();
        }

        public List<Habitacion> ObtenerTodas(string piso = "Todos", string estado = "Todos")
        {
            return _repo.Listar(piso, estado);
        }

        public Habitacion ObtenerPorNumero(int numero)
        {
            var h = _repo.ObtenerPorNumero(numero);
            if (h == null)
            {
                throw new Exception("La habitación número " + numero + " no existe.");
            }
            return h;
        }

        public void GuardarHabitacion(Habitacion habitacion)
        {
            if (habitacion == null) throw new ArgumentNullException("habitacion");
            if (habitacion.Numero <= 0) throw new ArgumentException("El número de habitación debe ser mayor a 0.");

            var existente = _repo.ObtenerPorNumero(habitacion.Numero);
            if (existente == null)
            {
                _repo.Crear(habitacion);
            }
            else
            {
                _repo.Actualizar(habitacion);
            }
        }

        public void CambiarEstado(int numero, string nuevoEstado)
        {
            var habitacion = ObtenerPorNumero(numero);
            if (habitacion.Estado == "Ocupada" && nuevoEstado == "Ocupada")
            {
                throw new HabitacionOcupadaException(numero);
            }

            _repo.CambiarEstado(numero, nuevoEstado);
        }

        public void Eliminar(int numero)
        {
            var hab = ObtenerPorNumero(numero);
            if (hab.Estado == "Ocupada")
            {
                throw new HabitacionOcupadaException(numero);
            }
            _repo.Eliminar(numero);
        }
    }
}
