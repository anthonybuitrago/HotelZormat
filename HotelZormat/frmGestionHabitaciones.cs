// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelZormat.Entidades;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmGestionHabitaciones : Form
    {
        private readonly HabitacionServicio _servicio;

        public frmGestionHabitaciones()
        {
            InitializeComponent();
            _servicio = new HabitacionServicio();
        }

        private void frmGestionHabitaciones_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            CargarHabitaciones();

            if (FrmPrincipal.UsuarioSesion != null && FrmPrincipal.UsuarioSesion.Rol != "Administrador")
            {
                btnEliminar.Enabled = false;
            }
        }

        private void CargarComboBoxes()
        {
            string[] tipos = new string[] { "Sencilla", "Doble", "Suite" };
            cboTipo.Items.Clear();
            // TODO: RUBRICA - Llenado de ComboBox con foreach
            foreach (string t in tipos)
            {
                cboTipo.Items.Add(t);
            }
            if (cboTipo.Items.Count > 0) cboTipo.SelectedIndex = 0;

            string[] pisos = new string[] { "1", "2", "3", "4" };
            cboPiso.Items.Clear();
            cboFiltroPiso.Items.Clear();
            cboFiltroPiso.Items.Add("Todos");

            foreach (string p in pisos)
            {
                cboPiso.Items.Add(p);
                cboFiltroPiso.Items.Add(p);
            }
            if (cboPiso.Items.Count > 0) cboPiso.SelectedIndex = 0;
            cboFiltroPiso.SelectedIndex = 0;

            string[] estados = new string[] { "Disponible", "Ocupada", "Reservada", "Limpieza" };
            cboEstado.Items.Clear();
            cboFiltroEstado.Items.Clear();
            cboFiltroEstado.Items.Add("Todos");

            foreach (string est in estados)
            {
                cboEstado.Items.Add(est);
                cboFiltroEstado.Items.Add(est);
            }
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            cboFiltroEstado.SelectedIndex = 0;
        }

        private void CargarHabitaciones()
        {
            try
            {
                string piso = cboFiltroPiso.SelectedItem != null ? cboFiltroPiso.SelectedItem.ToString() : "Todos";
                string estado = cboFiltroEstado.SelectedItem != null ? cboFiltroEstado.SelectedItem.ToString() : "Todos";

                List<Habitacion> lista = _servicio.ObtenerTodas(piso, estado);
                dgvHabitaciones.DataSource = null;
                dgvHabitaciones.DataSource = lista;
            }
            // TODO: RUBRICA - Manejo de errores con catch específicos para FormatException, SqlException, etc.
            catch (FormatException ex)
            {
                MessageBox.Show("Formato incorrecto al filtrar: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de habitaciones: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Habitacion h = new Habitacion
                {
                    Numero = int.Parse(txtNumero.Text),
                    Tipo = cboTipo.SelectedItem != null ? cboTipo.SelectedItem.ToString() : "Sencilla",
                    Piso = cboPiso.SelectedItem != null ? cboPiso.SelectedItem.ToString() : "1",
                    Estado = cboEstado.SelectedItem != null ? cboEstado.SelectedItem.ToString() : "Disponible",
                    Capacidad = int.Parse(txtCapacidad.Text),
                    TarifaBase = decimal.Parse(txtTarifa.Text)
                };

                _servicio.GuardarHabitacion(h);
                MessageBox.Show("Habitación creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LimpiarFormulario();
                CargarHabitaciones();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El número, capacidad y tarifa deben ser valores numéricos válidos.\nDetalles: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL al guardar la habitación: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show("Operación rechazada: La habitación #" + ex.NumeroHabitacion + " no puede modificarse en este momento.", "Habitación Ocupada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Seleccione una habitación para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Habitacion h = new Habitacion
                {
                    Numero = int.Parse(txtNumero.Text),
                    Tipo = cboTipo.SelectedItem != null ? cboTipo.SelectedItem.ToString() : "Sencilla",
                    Piso = cboPiso.SelectedItem != null ? cboPiso.SelectedItem.ToString() : "1",
                    Estado = cboEstado.SelectedItem != null ? cboEstado.SelectedItem.ToString() : "Disponible",
                    Capacidad = int.Parse(txtCapacidad.Text),
                    TarifaBase = decimal.Parse(txtTarifa.Text)
                };

                _servicio.GuardarHabitacion(h);
                MessageBox.Show("Habitación actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarHabitaciones();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Revise que los campos numéricos estén bien escritos: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL en actualización: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show(ex.Message, "Error de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Seleccione una habitación para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int num = int.Parse(txtNumero.Text);

                
                DialogResult dr = MessageBox.Show("¿Está seguro de eliminar la habitación #" + num + "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _servicio.Eliminar(num);
                    MessageBox.Show("Habitación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LimpiarFormulario();
                    CargarHabitaciones();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Número de habitación no válido: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede eliminar la habitación porque tiene registros asociados en SQL: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show(ex.Message, "No Permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNumero.Clear();
            txtCapacidad.Text = "2";
            txtTarifa.Text = "50.00";
            if (cboTipo.Items.Count > 0) cboTipo.SelectedIndex = 0;
            if (cboPiso.Items.Count > 0) cboPiso.SelectedIndex = 0;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            txtNumero.ReadOnly = false;
        }

        private void dgvHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow != null)
            {
                Habitacion hab = dgvHabitaciones.CurrentRow.DataBoundItem as Habitacion;
                if (hab != null)
                {
                    txtNumero.Text = hab.Numero.ToString();
                    txtNumero.ReadOnly = true;
                    cboTipo.SelectedItem = hab.Tipo;
                    cboPiso.SelectedItem = hab.Piso;
                    cboEstado.SelectedItem = hab.Estado;
                    txtCapacidad.Text = hab.Capacidad.ToString();
                    txtTarifa.Text = hab.TarifaBase.ToString("N2");
                }
            }
        }
    }
}
