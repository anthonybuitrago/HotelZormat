using System.Collections.Generic;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public interface IHabitacionRepository
    {
        List<Habitacion> Listar(string piso = "Todos", string estado = "Todos");
        Habitacion ObtenerPorNumero(int numero);
        void Crear(Habitacion h);
        void Actualizar(Habitacion h);
        void CambiarEstado(int numero, string nuevoEstado);
        void Eliminar(int numero);
    }
}
