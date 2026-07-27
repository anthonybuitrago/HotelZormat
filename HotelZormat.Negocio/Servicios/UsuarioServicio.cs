// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Security.Cryptography;
using System.Text;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class UsuarioServicio
    {
        private readonly UsuarioRepository _repo;
        private readonly BitacoraRepository _bitacoraRepo;

        public UsuarioServicio()
        {
            _repo = new UsuarioRepository();
            _bitacoraRepo = new BitacoraRepository();
        }

        public Usuario Login(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
            {
                throw new ArgumentException("El usuario y la clave no pueden estar vacíos.");
            }

            string claveHash = GenerarSHA256(clave);
            Usuario user = _repo.ValidarUsuario(usuario.Trim(), claveHash);

            if (user != null)
            {
                _bitacoraRepo.Registrar(user.Nombre, "Login Exitoso", "Inicio de sesión con rol " + user.Rol);
            }
            else
            {
                _bitacoraRepo.Registrar(usuario, "Intento de Login Fallido", "Credenciales incorrectas");
            }

            return user;
        }

        public static string GenerarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
