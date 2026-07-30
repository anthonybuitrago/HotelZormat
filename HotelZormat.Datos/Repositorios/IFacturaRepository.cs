using System;
using System.Collections.Generic;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public interface IFacturaRepository
    {
        void Guardar(Factura f);
        string GenerarSiguienteNCF();
        List<Factura> ObtenerPorRangoFechas(DateTime inicio, DateTime fin);
    }
}
