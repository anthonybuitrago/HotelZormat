// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;
using HotelZormat.Entidades;

namespace HotelZormat.Datos.Repositorios
{
    public class UsuarioRepository
    {
        public Usuario ValidarUsuario(string nombreUsuario, string claveHash)
        {
            Usuario usuario = null;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT Id, Nombre, Usuario, ClaveHash, Rol FROM dbo.Usuarios WHERE Usuario = @user AND ClaveHash = @pass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", nombreUsuario);
                    cmd.Parameters.AddWithValue("@pass", claveHash);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),
                                NombreUsuario = dr["Usuario"].ToString(),
                                ClaveHash = dr["ClaveHash"].ToString(),
                                Rol = dr["Rol"].ToString()
                            };
                        }
                    }
                }
            }

            return usuario;
        }
    }
}
