// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmReportes : Form
    {
        private readonly HabitacionServicio _habServicio;
        private readonly FacturacionServicio _factServicio;

        public frmReportes()
        {
            InitializeComponent();
            _habServicio = new HabitacionServicio();
            _factServicio = new FacturacionServicio();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Now.AddDays(-30);
            dtpFin.Value = DateTime.Now;

            CargarOcupacionDia();
            CargarIngresos();
        }

        private void btnCargarOcupacion_Click(object sender, EventArgs e)
        {
            CargarOcupacionDia();
        }

        private void CargarOcupacionDia()
        {
            try
            {
                // Listar habitaciones en estado Ocupada
                List<Habitacion> ocupadas = _habServicio.ObtenerTodas(piso: "Todos", estado: "Ocupada");
                dgvOcupacion.DataSource = null;
                dgvOcupacion.DataSource = ocupadas;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ocupación del día: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarIngresos_Click(object sender, EventArgs e)
        {
            CargarIngresos();
        }

        private void CargarIngresos()
        {
            try
            {
                List<Factura> facturas = _factServicio.ReporteIngresosPorFecha(dtpInicio.Value, dtpFin.Value);
                dgvIngresos.DataSource = null;
                dgvIngresos.DataSource = facturas;

                decimal sumaTotal = 0m;
                foreach (var f in facturas)
                {
                    sumaTotal += f.Total;
                }

                lblTotalIngresosVal.Text = "RD$ " + sumaTotal.ToString("N2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en las fechas seleccionadas: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL en reporte de ingresos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte de ingresos: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
