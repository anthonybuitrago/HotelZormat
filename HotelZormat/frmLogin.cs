// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioServicio _usuarioServicio;

        public frmLogin()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                Usuario u = _usuarioServicio.Login(usuario, clave);

                if (u != null)
                {
                    MessageBox.Show("¡Bienvenido " + u.Nombre + " (" + u.Rol + ")!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FrmPrincipal principal = new FrmPrincipal(u);
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en formato de datos ingresados: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexión con SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
