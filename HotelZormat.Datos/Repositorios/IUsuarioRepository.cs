using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public interface IUsuarioRepository
    {
        Usuario ValidarUsuario(string nombreUsuario, string claveHash);
    }
}
