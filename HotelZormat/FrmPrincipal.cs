// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat
{
    public partial class FrmPrincipal : Form
    {
        public static Usuario UsuarioSesion { get; private set; }

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            UsuarioSesion = usuario ?? new Usuario { Nombre = "Invitado", Rol = "Recepcionista" };
            
            lblUsuarioActivo.Text = "Usuario: " + UsuarioSesion.Nombre + " (" + UsuarioSesion.Rol + ")";

            // Permiso exclusivo para Administrador
            btnBitacora.Visible = (UsuarioSesion.Rol == "Administrador");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.ShowDialog();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            frmGestionHabitaciones frm = new frmGestionHabitaciones();
            frm.ShowDialog();
        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            frmGestionHuespedes frm = new frmGestionHuespedes();
            frm.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            frmReservas frm = new frmReservas();
            frm.ShowDialog();
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            frmCheckInCheckOut frm = new frmCheckInCheckOut();
            frm.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            if (UsuarioSesion.Rol != "Administrador")
            {
                MessageBox.Show("Acceso denegado. Solo el rol Administrador puede consultar la Bitácora.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmBitacora frm = new frmBitacora();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
