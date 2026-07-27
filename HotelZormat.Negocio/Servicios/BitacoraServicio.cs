// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System.Collections.Generic;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class BitacoraServicio
    {
        private readonly BitacoraRepository _repo;

        public BitacoraServicio()
        {
            _repo = new BitacoraRepository();
        }

        public List<Bitacora> ConsultarBitacora()
        {
            return _repo.ListarTodas();
        }

        public void RegistrarAccion(string usuario, string accion, string detalles)
        {
            _repo.Registrar(usuario, accion, detalles);
        }
    }
}
