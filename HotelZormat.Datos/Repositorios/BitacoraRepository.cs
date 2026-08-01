// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;
using HotelZormat.Entidades;

namespace HotelZormat.Datos.Repositorios
{
    public class BitacoraRepository
    {
        public void Registrar(string usuarioNombre, string accion, string detalles = "")
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "INSERT INTO dbo.Bitacora (UsuarioNombre, Accion, FechaHora, Detalles) VALUES (@Usuario, @Accion, GETDATE(), @Detalles)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuarioNombre ?? "Sistema");
                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@Detalles", (object)detalles ?? DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Bitacora> ListarTodas()
        {
            List<Bitacora> lista = new List<Bitacora>();

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT Id, UsuarioNombre, Accion, FechaHora, Detalles FROM dbo.Bitacora ORDER BY Id DESC";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Bitacora
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                UsuarioNombre = dr["UsuarioNombre"].ToString(),
                                Accion = dr["Accion"].ToString(),
                                FechaHora = Convert.ToDateTime(dr["FechaHora"]),
                                Detalles = dr["Detalles"] == DBNull.Value ? "" : dr["Detalles"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
