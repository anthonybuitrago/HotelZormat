// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Datos.Repositorios
{
    public class FacturaRepository
    {
        public void Guardar(Factura f)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"INSERT INTO dbo.Facturas (ReservaId, NCF, FechaEmision, Subtotal, ITBIS, PropinaLegal, Total)
                               VALUES (@ReservaId, @NCF, @FechaEmision, @Subtotal, @ITBIS, @PropinaLegal, @Total)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ReservaId", f.ReservaId);
                    cmd.Parameters.AddWithValue("@NCF", f.NCF);
                    cmd.Parameters.AddWithValue("@FechaEmision", f.FechaEmision);
                    cmd.Parameters.AddWithValue("@Subtotal", f.Subtotal);
                    cmd.Parameters.AddWithValue("@ITBIS", f.ITBIS);
                    cmd.Parameters.AddWithValue("@PropinaLegal", f.PropinaLegal);
                    cmd.Parameters.AddWithValue("@Total", f.Total);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string GenerarSiguienteNCF()
        {
            int siguienteNumero = 1;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM dbo.Facturas";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    siguienteNumero = count + 1;
                }
            }

            // Tipo B02: Factura de Consumo Final secuencial
            return "B02" + siguienteNumero.ToString("D8");
        }

        public List<Factura> ObtenerPorRangoFechas(DateTime inicio, DateTime fin)
        {
            List<Factura> lista = new List<Factura>();

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT Id, ReservaId, NCF, FechaEmision, Subtotal, ITBIS, PropinaLegal, Total 
                               FROM dbo.Facturas 
                               WHERE FechaEmision >= @Inicio AND FechaEmision <= @Fin
                               ORDER BY FechaEmision ASC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Inicio", inicio.Date);
                    cmd.Parameters.AddWithValue("@Fin", fin.Date.AddDays(1).AddTicks(-1));

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Factura
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                ReservaId = Convert.ToInt32(dr["ReservaId"]),
                                NCF = dr["NCF"].ToString(),
                                FechaEmision = Convert.ToDateTime(dr["FechaEmision"]),
                                Subtotal = Convert.ToDecimal(dr["Subtotal"]),
                                ITBIS = Convert.ToDecimal(dr["ITBIS"]),
                                PropinaLegal = Convert.ToDecimal(dr["PropinaLegal"]),
                                Total = Convert.ToDecimal(dr["Total"])
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
