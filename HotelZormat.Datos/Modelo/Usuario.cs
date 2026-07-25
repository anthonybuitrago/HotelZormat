// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
namespace HotelZormat.Negocio.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string ClaveHash { get; set; }
        public string Rol { get; set; }
    }
}
