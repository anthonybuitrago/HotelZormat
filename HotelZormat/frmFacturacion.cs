// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat
{
    public partial class frmFacturacion : Form
    {
        public frmFacturacion(Factura factura, Reserva reserva)
        {
            InitializeComponent();

            if (factura != null && reserva != null)
            {
                lblNCFVal.Text = factura.NCF;
                lblFechaVal.Text = factura.FechaEmision.ToString("dd/MM/yyyy HH:mm");
                lblHuespedVal.Text = reserva.NombreHuesped;
                lblHabitacionVal.Text = "Habitación #" + reserva.NumeroHabitacion + " (" + reserva.TotalNoches + " Noches)";
                lblSubtotalVal.Text = "RD$ " + factura.Subtotal.ToString("N2");
                lblITBISVal.Text = "RD$ " + factura.ITBIS.ToString("N2");
                lblPropinaVal.Text = "RD$ " + factura.PropinaLegal.ToString("N2");
                lblTotalVal.Text = "RD$ " + factura.Total.ToString("N2");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura enviada a la impresora.", "Impresión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
