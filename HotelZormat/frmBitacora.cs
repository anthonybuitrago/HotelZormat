// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmBitacora : Form
    {
        private readonly BitacoraServicio _servicio;

        public frmBitacora()
        {
            InitializeComponent();
            _servicio = new BitacoraServicio();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                List<Bitacora> lista = _servicio.ConsultarBitacora();
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = lista;
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
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
