using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmGestionHabitaciones : Form
    {
        private HabitacionServicio _servicio;
        private Habitacion _habitacionActual;

        public frmGestionHabitaciones()
        {
            InitializeComponent();
            _servicio = new HabitacionServicio();
        }

        private void frmGestionHabitaciones_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Sencilla");
            cboTipo.Items.Add("Doble");
            cboTipo.Items.Add("Suite");

            var todas = _servicio.ObtenerTodas();
            lstHabitaciones.Items.Clear();
            foreach (var h in todas)
            {
                if (h.Piso == "3")
                {
                    lstHabitaciones.Items.Add($"{h.Numero} - {h.Tipo}");
                }
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cboTipo.SelectedItem?.ToString();

            switch (tipo)
            {
                case "Sencilla":
                    lblIcono.Text = "🛏️";
                    break;
                case "Doble":
                    lblIcono.Text = "🛏️🛏️";
                    break;
                case "Suite":
                    lblIcono.Text = "👑";
                    break;
                default:
                    lblIcono.Text = "❓";
                    break;
            }

            try
            {
                decimal tarifa = ObtenerTarifa(tipo);
                lblTarifa.Text = $"$ {tarifa}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private decimal ObtenerTarifa(string tipo)
        {
            switch (tipo)
            {
                case "Sencilla":
                    return 50.0m;
                case "Doble":
                    return 80.0m;
                case "Suite":
                    return 150.0m;
                default:
                    throw new ArgumentException("Tipo de habitación no válido");
            }
        }

        private void CambiarColorEstado(string estado)
        {
            switch (estado)
            {
                case "Disponible":
                    lblEstado.ForeColor = Color.Green;
                    break;
                case "Ocupada":
                    lblEstado.ForeColor = Color.Red;
                    break;
                case "Mantenimiento":
                    lblEstado.ForeColor = Color.Orange;
                    break;
                case "Limpieza":
                    lblEstado.ForeColor = Color.Blue;
                    break;
                default:
                    lblEstado.ForeColor = Color.Black;
                    break;
            }
        }

        private void HabilitarBoton(string estado)
        {
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
            btnLimpiar.Enabled = false;
            btnMantenimiento.Enabled = false;

            switch (estado)
            {
                case "Disponible":
                    btnCheckIn.Enabled = true;
                    break;
                case "Ocupada":
                    btnCheckOut.Enabled = true;
                    break;
                case "Mantenimiento":
                    btnMantenimiento.Enabled = true;
                    break;
                case "Limpieza":
                    btnLimpiar.Enabled = true;
                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string accion = cboAccion.SelectedItem?.ToString();
            string mensaje = "";

            switch (accion)
            {
                case "Check-In":
                    mensaje = "¿Desea registrar la entrada del huésped?";
                    break;
                case "Check-Out":
                    mensaje = "¿Desea registrar la salida del huésped y emitir la factura?";
                    break;
                case "Limpiar":
                    mensaje = "¿Confirmar que la habitación está lista y limpia?";
                    break;
                case "Mantenimiento":
                    mensaje = "¿Enviar habitación a mantenimiento?";
                    break;
                default:
                    MessageBox.Show("Seleccione una acción");
                    return;
            }

            MessageBox.Show(mensaje, "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtBuscar.Text);
                _habitacionActual = _servicio.ObtenerPorNumero(num);
                
                lblEstado.Text = _habitacionActual.Estado;
                CambiarColorEstado(_habitacionActual.Estado);
                HabilitarBoton(_habitacionActual.Estado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            
            try
            {
                if (_habitacionActual == null) return;
                
                _habitacionActual.Estado = "Ocupada";
                _servicio.GuardarHabitacion(_habitacionActual);
                MessageBox.Show("Guardado con éxito");
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
    }
}
