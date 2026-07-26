// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public class HabitacionRepository
    {
        public List<Habitacion> Listar(string piso = "Todos", string estado = "Todos")
        {
            List<Habitacion> lista = new List<Habitacion>();

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT Id, Numero, Tipo, Piso, Estado, Capacidad, TarifaBase FROM dbo.Habitaciones WHERE 1=1";

                if (!string.IsNullOrEmpty(piso) && piso != "Todos")
                {
                    sql += " AND Piso = @Piso";
                }
                if (!string.IsNullOrEmpty(estado) && estado != "Todos")
                {
                    sql += " AND Estado = @Estado";
                }

                sql += " ORDER BY Numero ASC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (!string.IsNullOrEmpty(piso) && piso != "Todos")
                    {
                        cmd.Parameters.AddWithValue("@Piso", piso);
                    }
                    if (!string.IsNullOrEmpty(estado) && estado != "Todos")
                    {
                        cmd.Parameters.AddWithValue("@Estado", estado);
                    }

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Habitacion
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Numero = Convert.ToInt32(dr["Numero"]),
                                Tipo = dr["Tipo"].ToString(),
                                Piso = dr["Piso"].ToString(),
                                Estado = dr["Estado"].ToString(),
                                Capacidad = Convert.ToInt32(dr["Capacidad"]),
                                TarifaBase = Convert.ToDecimal(dr["TarifaBase"])
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public Habitacion ObtenerPorNumero(int numero)
        {
            Habitacion hab = null;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT Id, Numero, Tipo, Piso, Estado, Capacidad, TarifaBase FROM dbo.Habitaciones WHERE Numero = @Numero";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Numero", numero);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            hab = new Habitacion
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Numero = Convert.ToInt32(dr["Numero"]),
                                Tipo = dr["Tipo"].ToString(),
                                Piso = dr["Piso"].ToString(),
                                Estado = dr["Estado"].ToString(),
                                Capacidad = Convert.ToInt32(dr["Capacidad"]),
                                TarifaBase = Convert.ToDecimal(dr["TarifaBase"])
                            };
                        }
                    }
                }
            }

            return hab;
        }

        public void Crear(Habitacion h)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "INSERT INTO dbo.Habitaciones (Numero, Tipo, Piso, Estado, Capacidad, TarifaBase) " +
                             "VALUES (@Numero, @Tipo, @Piso, @Estado, @Capacidad, @TarifaBase)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Numero", h.Numero);
                    cmd.Parameters.AddWithValue("@Tipo", h.Tipo);
                    cmd.Parameters.AddWithValue("@Piso", h.Piso);
                    cmd.Parameters.AddWithValue("@Estado", h.Estado ?? "Disponible");
                    cmd.Parameters.AddWithValue("@Capacidad", h.Capacidad);
                    cmd.Parameters.AddWithValue("@TarifaBase", h.TarifaBase);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Habitacion h)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "UPDATE dbo.Habitaciones SET Tipo = @Tipo, Piso = @Piso, Estado = @Estado, " +
                             "Capacidad = @Capacidad, TarifaBase = @TarifaBase WHERE Numero = @Numero";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Tipo", h.Tipo);
                    cmd.Parameters.AddWithValue("@Piso", h.Piso);
                    cmd.Parameters.AddWithValue("@Estado", h.Estado);
                    cmd.Parameters.AddWithValue("@Capacidad", h.Capacidad);
                    cmd.Parameters.AddWithValue("@TarifaBase", h.TarifaBase);
                    cmd.Parameters.AddWithValue("@Numero", h.Numero);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int numero, string nuevoEstado)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "UPDATE dbo.Habitaciones SET Estado = @Estado WHERE Numero = @Numero";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@Numero", numero);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int numero)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "DELETE FROM dbo.Habitaciones WHERE Numero = @Numero";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Numero", numero);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
