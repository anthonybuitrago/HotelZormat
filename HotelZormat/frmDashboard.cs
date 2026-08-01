// Pasaporte: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using HotelZormat.Entidades;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat
{
    public partial class frmDashboard : Form
    {
        private readonly HabitacionServicio _servicio;

        public frmDashboard()
        {
            InitializeComponent();
            _servicio = new HabitacionServicio();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private void CargarTablero()
        {
            try
            {
                flpHabitaciones.Controls.Clear();
                List<Habitacion> lista = _servicio.ObtenerTodas();

                foreach (Habitacion hab in lista)
                {
                    Button btn = new Button
                    {
                        Width = 130,
                        Height = 90,
                        Text = "Hab. " + hab.Numero + "\n" + hab.Tipo + "\n[" + hab.Estado + "]",
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                        Margin = new Padding(10),
                        FlatStyle = FlatStyle.Flat,
                        Tag = hab
                    };

                    btn.FlatAppearance.BorderSize = 0;

                    // Colores por Estado (Verde, Rojo, Naranja, Azul)
                                        // TODO: RUBRICA - Vista visual con switch para colores por estado
switch (hab.Estado)
                    {
                        case "Disponible":
                            btn.BackColor = Color.FromArgb(46, 139, 87); // Verde
                            btn.ForeColor = Color.White;
                            break;
                        case "Ocupada":
                            btn.BackColor = Color.FromArgb(178, 34, 34); // Rojo
                            btn.ForeColor = Color.White;
                            break;
                        case "Reservada":
                            btn.BackColor = Color.FromArgb(218, 112, 21); // Naranja
                            btn.ForeColor = Color.White;
                            break;
                        case "Limpieza":
                            btn.BackColor = Color.FromArgb(25, 118, 210); // Azul
                            btn.ForeColor = Color.White;
                            break;
                        default:
                            btn.BackColor = Color.Gray;
                            btn.ForeColor = Color.White;
                            break;
                    }

                    btn.Click += BtnHabitacion_Click;
                    flpHabitaciones.Controls.Add(btn);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en formato de datos: " + ex.Message, "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos SQL Server: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tablero: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHabitacion_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Habitacion hab = btn.Tag as Habitacion;
                if (hab != null)
                {
                    MessageBox.Show("Habitación #" + hab.Numero + "\nTipo: " + hab.Tipo + "\nPiso: " + hab.Piso + "\nEstado: " + hab.Estado + "\nTarifa Base: RD$" + hab.TarifaBase.ToString("N2"),
                                    "Detalle Habitación " + hab.Numero, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
