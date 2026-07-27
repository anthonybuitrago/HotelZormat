// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class FacturacionServicio
    {
        private readonly FacturaRepository _facturaRepo;
        private readonly ReservaRepository _reservaRepo;
        private readonly HabitacionRepository _habRepo;
        private readonly BitacoraRepository _bitacoraRepo;

        public const decimal ITBIS_PORCENTAJE = 0.18m;
        public const decimal PROPINA_PORCENTAJE = 0.10m;

        public FacturacionServicio()
        {
            _facturaRepo = new FacturaRepository();
            _reservaRepo = new ReservaRepository();
            _habRepo = new HabitacionRepository();
            _bitacoraRepo = new BitacoraRepository();
        }

        public void RealizarCheckIn(int reservaId, string usuarioActual)
        {
            var reserva = _reservaRepo.ObtenerPorId(reservaId);
            if (reserva == null) throw new Exception("Reserva no encontrada.");

            _reservaRepo.CambiarEstado(reservaId, "Confirmada");
            _habRepo.CambiarEstado(reserva.NumeroHabitacion, "Ocupada");

            _bitacoraRepo.Registrar(usuarioActual, "Check-In", "Check-In realizado para reserva #" + reservaId + ", Habitación #" + reserva.NumeroHabitacion);
        }

        public Factura RealizarCheckOutYFacturar(int reservaId, string usuarioActual)
        {
            var reserva = _reservaRepo.ObtenerPorId(reservaId);
            if (reserva == null) throw new Exception("Reserva no encontrada.");

            decimal subtotal = reserva.MontoTotal;
            decimal itbis = subtotal * ITBIS_PORCENTAJE;
            decimal propina = subtotal * PROPINA_PORCENTAJE;
            decimal total = subtotal + itbis + propina;

            string ncf = _facturaRepo.GenerarSiguienteNCF();

            Factura factura = new Factura
            {
                ReservaId = reservaId,
                NCF = ncf,
                FechaEmision = DateTime.Now,
                Subtotal = subtotal,
                ITBIS = itbis,
                PropinaLegal = propina,
                Total = total
            };

            _facturaRepo.Guardar(factura);

            // Actualizar estados
            _reservaRepo.CambiarEstado(reservaId, "Completada");
            _habRepo.CambiarEstado(reserva.NumeroHabitacion, "Limpieza");

            _bitacoraRepo.Registrar(usuarioActual, "Check-Out / Facturación", "Factura NCF " + ncf + " emitida por RD$" + total.ToString("N2") + " para la reserva #" + reservaId);

            return factura;
        }

        public List<Factura> ReporteIngresosPorFecha(DateTime inicio, DateTime fin)
        {
            return _facturaRepo.ObtenerPorRangoFechas(inicio, fin);
        }
    }
}
