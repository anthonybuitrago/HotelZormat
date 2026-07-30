using System.Collections.Generic;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public interface IReservaRepository
    {
        List<Reserva> ListarProximas(int dias = 7);
        List<Reserva> ListarTodas();
        Reserva ObtenerPorId(int id);
        void Crear(Reserva r);
        void CambiarEstado(int reservaId, string nuevoEstado);
    }
}
