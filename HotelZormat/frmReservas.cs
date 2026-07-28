// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmReservas : Form
    {
        private readonly ReservaServicio _reservaServicio;
        private readonly HabitacionServicio _habServicio;
        private readonly HuespedServicio _huespedServicio;

        public frmReservas()
        {
            InitializeComponent();
            _reservaServicio = new ReservaServicio();
            _habServicio = new HabitacionServicio();
            _huespedServicio = new HuespedServicio();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);

            CargarCombos();
            CargarReservas();
        }

        private void CargarCombos()
        {
            try
            {
                cboTemporada.Items.Clear();
                string[] temporadas = new string[] { "Alta", "Media", "Baja" };
                foreach (string temp in temporadas)
                {
                    cboTemporada.Items.Add(temp);
                }
                cboTemporada.SelectedIndex = 0;

                cboHuespedes.Items.Clear();
                List<Huesped> huespedes = _huespedServicio.Listar();
                foreach (var h in huespedes)
                {
                    cboHuespedes.Items.Add(new KeyValuePair<int, string>(h.Id, h.Nombre + " (" + h.NumeroDocumento + ")"));
                }
                cboHuespedes.DisplayMember = "Value";
                cboHuespedes.ValueMember = "Key";
                if (cboHuespedes.Items.Count > 0) cboHuespedes.SelectedIndex = 0;

                cboHabitaciones.Items.Clear();
                List<Habitacion> habitaciones = _habServicio.ObtenerTodas();
                foreach (var hab in habitaciones)
                {
                    if (hab.Estado == "Disponible")
                    {
                        cboHabitaciones.Items.Add(hab);
                    }
                }
                cboHabitaciones.DisplayMember = "Numero";
                if (cboHabitaciones.Items.Count > 0) cboHabitaciones.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos auxiliares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReservas()
        {
            try
            {
                List<Reserva> lista = _reservaServicio.ListarProximas(7);
                dgvReservas.DataSource = null;
                dgvReservas.DataSource = lista;
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
                MessageBox.Show("Error al cargar reservas: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularReserva_Event(object sender, EventArgs e)
        {
            try
            {
                if (dtpCheckOut.Value <= dtpCheckIn.Value)
                {
                    lblNochesCalculadas.Text = "0";
                    lblMontoCalculado.Text = "RD$ 0.00";
                    return;
                }

                int noches = _reservaServicio.CalcularNoches(dtpCheckIn.Value, dtpCheckOut.Value);
                lblNochesCalculadas.Text = noches.ToString();

                Habitacion hab = cboHabitaciones.SelectedItem as Habitacion;
                if (hab != null && cboTemporada.SelectedItem != null)
                {
                    string temporada = cboTemporada.SelectedItem.ToString();
                    decimal monto = _reservaServicio.CalcularMonto(hab.TarifaBase, noches, temporada);
                    lblMontoCalculado.Text = "RD$ " + monto.ToString("N2");
                }
            }
            catch
            {
                lblNochesCalculadas.Text = "0";
                lblMontoCalculado.Text = "RD$ 0.00";
            }
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboHuespedes.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un huésped.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboHabitaciones.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una habitación disponible.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KeyValuePair<int, string> huespedSeleccionado = (KeyValuePair<int, string>)cboHuespedes.SelectedItem;
                Habitacion habSeleccionada = (Habitacion)cboHabitaciones.SelectedItem;

                Reserva r = new Reserva
                {
                    HuespedId = huespedSeleccionado.Key,
                    HabitacionId = habSeleccionada.Id,
                    NumeroHabitacion = habSeleccionada.Numero,
                    FechaCheckIn = dtpCheckIn.Value,
                    FechaCheckOut = dtpCheckOut.Value,
                    Temporada = cboTemporada.SelectedItem != null ? cboTemporada.SelectedItem.ToString() : "Alta",
                    Estado = "Confirmada"
                };

                _reservaServicio.CrearReserva(r);
                MessageBox.Show("Reserva creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
                CargarReservas();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de fecha o valor numérico incorrecto: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ReservaInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Reserva Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar reserva: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
