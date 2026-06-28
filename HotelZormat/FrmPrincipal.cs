using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelZormat
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string connStr = ConfiguracionDB.ObtenerConnectionString();
            string connStr = "";

            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    var cmd = new SqlCommand("SELECT COUNT(*) FROM Habitaciones", conn);
                    int total = (int)cmd.ExecuteScalar();

                    MessageBox.Show("Conectado. Hay " + total + " habitaciones en la BD.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexion:" + ex.Message, "BD inaccesible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
