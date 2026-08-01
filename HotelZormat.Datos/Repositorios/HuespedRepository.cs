// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;
using HotelZormat.Entidades;

namespace HotelZormat.Datos.Repositorios
{
    public class HuespedRepository
    {
        public List<Huesped> Listar(string busqueda = "")
        {
            List<Huesped> lista = new List<Huesped>();

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT Id, TipoDocumento, NumeroDocumento, Nombre, Telefono, Email FROM dbo.Huespedes WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    sql += " AND (NumeroDocumento LIKE @Busqueda OR Nombre LIKE @Busqueda)";
                }

                sql += " ORDER BY Nombre ASC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (!string.IsNullOrWhiteSpace(busqueda))
                    {
                        cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                    }

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Huesped
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Telefono = dr["Telefono"] == DBNull.Value ? "" : dr["Telefono"].ToString(),
                                Email = dr["Email"] == DBNull.Value ? "" : dr["Email"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public Huesped ObtenerPorId(int id)
        {
            Huesped huesped = null;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT Id, TipoDocumento, NumeroDocumento, Nombre, Telefono, Email FROM dbo.Huespedes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            huesped = new Huesped
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Telefono = dr["Telefono"] == DBNull.Value ? "" : dr["Telefono"].ToString(),
                                Email = dr["Email"] == DBNull.Value ? "" : dr["Email"].ToString()
                            };
                        }
                    }
                }
            }

            return huesped;
        }

        public void Crear(Huesped h)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "INSERT INTO dbo.Huespedes (TipoDocumento, NumeroDocumento, Nombre, Telefono, Email) " +
                             "VALUES (@TipoDoc, @NumDoc, @Nombre, @Telefono, @Email)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TipoDoc", h.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumDoc", h.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@Nombre", h.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", (object)h.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)h.Email ?? DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Huesped h)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "UPDATE dbo.Huespedes SET TipoDocumento = @TipoDoc, NumeroDocumento = @NumDoc, " +
                             "Nombre = @Nombre, Telefono = @Telefono, Email = @Email WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TipoDoc", h.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumDoc", h.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@Nombre", h.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", (object)h.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)h.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", h.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "DELETE FROM dbo.Huespedes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
