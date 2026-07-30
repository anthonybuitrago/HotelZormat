using System.Collections.Generic;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public interface IBitacoraRepository
    {
        void Registrar(string usuarioNombre, string accion, string detalles = "");
        List<Bitacora> ListarTodas();
    }
}
