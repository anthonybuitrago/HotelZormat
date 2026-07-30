using System.Collections.Generic;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public interface IHuespedRepository
    {
        List<Huesped> Listar(string busqueda = "");
        Huesped ObtenerPorId(int id);
        void Crear(Huesped h);
        void Actualizar(Huesped h);
        void Eliminar(int id);
    }
}
