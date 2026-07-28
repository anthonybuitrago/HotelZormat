// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmCheckInCheckOut : Form
    {
        private readonly ReservaServicio _reservaServicio;
        private readonly FacturacionServicio _facturacionServicio;

        public frmCheckInCheckOut()
        {
            InitializeComponent();
            _reservaServicio = new ReservaServicio();
            _facturacionServicio = new FacturacionServicio();
        }

        private void frmCheckInCheckOut_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                List<Reserva> lista = _reservaServicio.ListarTodas();
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
                MessageBox.Show("Error al cargar lista de reservas: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                Reserva r = dgvReservas.CurrentRow.DataBoundItem as Reserva;
                if (r != null)
                {
                    btnCheckIn.Enabled = (r.Estado == "Pendiente" || r.Estado == "Confirmada");
                    btnCheckOut.Enabled = (r.Estado == "Confirmada");
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una reserva válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reserva r = dgvReservas.CurrentRow.DataBoundItem as Reserva;
                if (r == null) return;

                DialogResult dr = MessageBox.Show("¿Confirmar Check-In para el huésped " + r.NombreHuesped + " en la habitación #" + r.NumeroHabitacion + "?", "Confirmar Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string usuario = (FrmPrincipal.UsuarioSesion != null ? FrmPrincipal.UsuarioSesion.Nombre : "Sistema");
                    _facturacionServicio.RealizarCheckIn(r.Id, usuario);

                    MessageBox.Show("Check-In registrado exitosamente. La habitación ahora está OCUPADA.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReservas();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en datos de entrada: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar Check-In: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una reserva en curso para procesar el Check-Out.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reserva r = dgvReservas.CurrentRow.DataBoundItem as Reserva;
                if (r == null) return;

                DialogResult dr = MessageBox.Show("¿Confirmar Check-Out y emitir factura para la reserva #" + r.Id + "?", "Confirmar Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string usuario = (FrmPrincipal.UsuarioSesion != null ? FrmPrincipal.UsuarioSesion.Nombre : "Sistema");
                    Factura facturaGenerada = _facturacionServicio.RealizarCheckOutYFacturar(r.Id, usuario);

                    MessageBox.Show("Check-Out completado con éxito. La habitación ha pasado a estado LIMPIEZA.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir pantalla de desglose de factura
                    frmFacturacion frmFact = new frmFacturacion(facturaGenerada, r);
                    frmFact.ShowDialog();

                    CargarReservas();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato al facturar: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server al emitir NCF: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar Check-Out: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
