// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Entidades;
using HotelZormat.Negocio.Excepciones;

namespace HotelZormat.Negocio.Servicios
{
    public class ReservaServicio
    {
        private readonly ReservaRepository _repo;
        private readonly HabitacionRepository _habRepo;

        public ReservaServicio()
        {
            _repo = new ReservaRepository();
            _habRepo = new HabitacionRepository();
        }

        public List<Reserva> ListarTodas()
        {
            return _repo.ListarTodas();
        }

        public List<Reserva> ListarProximas(int dias = 7)
        {
            return _repo.ListarProximas(dias);
        }

        public Reserva ObtenerPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }

        public decimal ObtenerDescuentoPorTemporada(string temporada)
        {
            decimal factor;

            switch (temporada)
            {
                case "Alta":
                    factor = 0.00m; // Sin descuento
                    break;
                case "Media":
                    factor = 0.10m; // 10% de descuento
                    break;
                case "Baja":
                    factor = 0.20m; // 20% de descuento
                    break;
                default:
                    factor = 0.00m;
                    break;
            }

            return factor;
        }

        public int CalcularNoches(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new ReservaInvalidaException("La fecha de check-out debe ser posterior a la fecha de check-in.");
            }

            TimeSpan diferencia = checkOut.Date - checkIn.Date;
            return (int)diferencia.TotalDays;
        }

        public decimal CalcularMonto(decimal tarifaBase, int noches, string temporada)
        {
            decimal descuento = ObtenerDescuentoPorTemporada(temporada);
            decimal tarifaPorNoche = tarifaBase * (1.0m - descuento);
            return tarifaPorNoche * noches;
        }

        public void CrearReserva(Reserva r)
        {
            if (r == null) throw new ArgumentNullException("r");
            if (r.HuespedId <= 0) throw new ReservaInvalidaException("Debe seleccionar un huésped.");
            if (r.HabitacionId <= 0) throw new ReservaInvalidaException("Debe seleccionar una habitación.");

            r.TotalNoches = CalcularNoches(r.FechaCheckIn, r.FechaCheckOut);

            var hab = _habRepo.ObtenerPorNumero(r.NumeroHabitacion > 0 ? r.NumeroHabitacion : r.HabitacionId);
            if (hab != null)
            {
                r.HabitacionId = hab.Id;
                r.MontoTotal = CalcularMonto(hab.TarifaBase, r.TotalNoches, r.Temporada);
            }

            if (r.Estado == null) r.Estado = "Confirmada";

            _repo.Crear(r);

            if (hab != null && hab.Estado == "Disponible")
            {
                _habRepo.CambiarEstado(hab.Numero, "Reservada");
            }
        }

        public void CambiarEstado(int reservaId, string nuevoEstado)
        {
            _repo.CambiarEstado(reservaId, nuevoEstado);
        }
    }
}
