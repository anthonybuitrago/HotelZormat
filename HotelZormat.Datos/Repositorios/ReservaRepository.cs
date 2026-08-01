// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;
using HotelZormat.Entidades;

namespace HotelZormat.Datos.Repositorios
{
    public class ReservaRepository
    {
        public List<Reserva> ListarProximas(int dias = 7)
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT r.Id, r.HuespedId, r.HabitacionId, r.FechaCheckIn, r.FechaCheckOut, 
                                      r.Temporada, r.Estado, r.TotalNoches, r.MontoTotal,
                                      h.Nombre AS NombreHuesped, hab.Numero AS NumeroHabitacion
                               FROM dbo.Reservas r
                               INNER JOIN dbo.Huespedes h ON r.HuespedId = h.Id
                               INNER JOIN dbo.Habitaciones hab ON r.HabitacionId = hab.Id
                               WHERE r.FechaCheckIn <= DATEADD(day, @Dias, GETDATE())
                               ORDER BY r.FechaCheckIn ASC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Dias", dias);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(MapearReserva(dr));
                        }
                    }
                }
            }

            return lista;
        }

        public List<Reserva> ListarTodas()
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT r.Id, r.HuespedId, r.HabitacionId, r.FechaCheckIn, r.FechaCheckOut, 
                                      r.Temporada, r.Estado, r.TotalNoches, r.MontoTotal,
                                      h.Nombre AS NombreHuesped, hab.Numero AS NumeroHabitacion
                               FROM dbo.Reservas r
                               INNER JOIN dbo.Huespedes h ON r.HuespedId = h.Id
                               INNER JOIN dbo.Habitaciones hab ON r.HabitacionId = hab.Id
                               ORDER BY r.Id DESC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(MapearReserva(dr));
                        }
                    }
                }
            }

            return lista;
        }

        public Reserva ObtenerPorId(int id)
        {
            Reserva reserva = null;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT r.Id, r.HuespedId, r.HabitacionId, r.FechaCheckIn, r.FechaCheckOut, 
                                      r.Temporada, r.Estado, r.TotalNoches, r.MontoTotal,
                                      h.Nombre AS NombreHuesped, hab.Numero AS NumeroHabitacion
                               FROM dbo.Reservas r
                               INNER JOIN dbo.Huespedes h ON r.HuespedId = h.Id
                               INNER JOIN dbo.Habitaciones hab ON r.HabitacionId = hab.Id
                               WHERE r.Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            reserva = MapearReserva(dr);
                        }
                    }
                }
            }

            return reserva;
        }

        public void Crear(Reserva r)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"INSERT INTO dbo.Reservas (HuespedId, HabitacionId, FechaCheckIn, FechaCheckOut, Temporada, Estado, TotalNoches, MontoTotal)
                               VALUES (@HuespedId, @HabitacionId, @FechaCheckIn, @FechaCheckOut, @Temporada, @Estado, @TotalNoches, @MontoTotal)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@HuespedId", r.HuespedId);
                    cmd.Parameters.AddWithValue("@HabitacionId", r.HabitacionId);
                    cmd.Parameters.AddWithValue("@FechaCheckIn", r.FechaCheckIn);
                    cmd.Parameters.AddWithValue("@FechaCheckOut", r.FechaCheckOut);
                    cmd.Parameters.AddWithValue("@Temporada", r.Temporada);
                    cmd.Parameters.AddWithValue("@Estado", r.Estado ?? "Pendiente");
                    cmd.Parameters.AddWithValue("@TotalNoches", r.TotalNoches);
                    cmd.Parameters.AddWithValue("@MontoTotal", r.MontoTotal);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int reservaId, string nuevoEstado)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "UPDATE dbo.Reservas SET Estado = @Estado WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@Id", reservaId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Reserva MapearReserva(SqlDataReader dr)
        {
            return new Reserva
            {
                Id = Convert.ToInt32(dr["Id"]),
                HuespedId = Convert.ToInt32(dr["HuespedId"]),
                HabitacionId = Convert.ToInt32(dr["HabitacionId"]),
                FechaCheckIn = Convert.ToDateTime(dr["FechaCheckIn"]),
                FechaCheckOut = Convert.ToDateTime(dr["FechaCheckOut"]),
                Temporada = dr["Temporada"].ToString(),
                Estado = dr["Estado"].ToString(),
                TotalNoches = Convert.ToInt32(dr["TotalNoches"]),
                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                NombreHuesped = dr["NombreHuesped"].ToString(),
                NumeroHabitacion = Convert.ToInt32(dr["NumeroHabitacion"])
            };
        }
    }
}
