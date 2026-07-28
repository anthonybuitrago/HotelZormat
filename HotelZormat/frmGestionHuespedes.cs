// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmGestionHuespedes : Form
    {
        private readonly HuespedServicio _servicio;
        private int _idSeleccionado = 0;

        public frmGestionHuespedes()
        {
            InitializeComponent();
            _servicio = new HuespedServicio();
        }

        private void frmGestionHuespedes_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Clear();
            cboTipoDocumento.Items.Add("Cédula");
            cboTipoDocumento.Items.Add("Pasaporte");
            cboTipoDocumento.SelectedIndex = 0;

            CargarHuespedes();
        }

        private void CargarHuespedes(string busqueda = "")
        {
            try
            {
                List<Huesped> lista = _servicio.Listar(busqueda);
                dgvHuespedes.DataSource = null;
                dgvHuespedes.DataSource = lista;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar huéspedes: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarHuespedes(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Huesped h = new Huesped
                {
                    Id = 0,
                    TipoDocumento = cboTipoDocumento.SelectedItem != null ? cboTipoDocumento.SelectedItem.ToString() : "Cédula",
                    NumeroDocumento = txtNumeroDocumento.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };

                _servicio.Guardar(h);
                MessageBox.Show("Huésped registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarHuespedes();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Compruebe los datos ingresados: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server (cédula/pasaporte duplicado): " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un huésped para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Huesped h = new Huesped
                {
                    Id = _idSeleccionado,
                    TipoDocumento = cboTipoDocumento.SelectedItem != null ? cboTipoDocumento.SelectedItem.ToString() : "Cédula",
                    NumeroDocumento = txtNumeroDocumento.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };

                _servicio.Guardar(h);
                MessageBox.Show("Huésped actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarHuespedes();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Compruebe los datos ingresados: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL en actualización: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un huésped para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Desea eliminar el huésped " + txtNombre.Text + "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _servicio.Eliminar(_idSeleccionado);
                    MessageBox.Show("Huésped eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    CargarHuespedes();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede eliminar el huésped porque tiene reservas registradas en BD.", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _idSeleccionado = 0;
            txtNumeroDocumento.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            if (cboTipoDocumento.Items.Count > 0) cboTipoDocumento.SelectedIndex = 0;
        }

        private void dgvHuespedes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHuespedes.CurrentRow != null)
            {
                Huesped h = dgvHuespedes.CurrentRow.DataBoundItem as Huesped;
                if (h != null)
                {
                    _idSeleccionado = h.Id;
                    cboTipoDocumento.SelectedItem = h.TipoDocumento;
                    txtNumeroDocumento.Text = h.NumeroDocumento;
                    txtNombre.Text = h.Nombre;
                    txtTelefono.Text = h.Telefono;
                    txtEmail.Text = h.Email;
                }
            }
        }
    }
}
