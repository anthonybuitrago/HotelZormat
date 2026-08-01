namespace HotelZormat
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.flpHabitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeyenda = new System.Windows.Forms.Panel();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblNaranja = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlLeyenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(20, 35, 60);
            this.pnlEncabezado.Controls.Add(this.btnRefrescar);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(780, 50);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tablero de Estado (Dashboard)";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(650, 10);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(115, 30);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "🔄 Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // flpHabitaciones
            // 
            this.flpHabitaciones.AutoScroll = true;
            this.flpHabitaciones.BackColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this.flpHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHabitaciones.Location = new System.Drawing.Point(0, 50);
            this.flpHabitaciones.Name = "flpHabitaciones";
            this.flpHabitaciones.Padding = new System.Windows.Forms.Padding(15);
            this.flpHabitaciones.Size = new System.Drawing.Size(780, 370);
            this.flpHabitaciones.TabIndex = 1;
            // 
            // pnlLeyenda
            // 
            this.pnlLeyenda.BackColor = System.Drawing.Color.White;
            this.pnlLeyenda.Controls.Add(this.lblAzul);
            this.pnlLeyenda.Controls.Add(this.lblNaranja);
            this.pnlLeyenda.Controls.Add(this.lblRojo);
            this.pnlLeyenda.Controls.Add(this.lblVerde);
            this.pnlLeyenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLeyenda.Location = new System.Drawing.Point(0, 420);
            this.pnlLeyenda.Name = "pnlLeyenda";
            this.pnlLeyenda.Size = new System.Drawing.Size(780, 40);
            this.pnlLeyenda.TabIndex = 2;
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVerde.ForeColor = System.Drawing.Color.FromArgb(60, 179, 113);
            this.lblVerde.Location = new System.Drawing.Point(30, 10);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(145, 17);
            this.lblVerde.TabIndex = 0;
            this.lblVerde.Text = "🟩 Verde = Disponible";
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRojo.ForeColor = System.Drawing.Color.FromArgb(205, 92, 92);
            this.lblRojo.Location = new System.Drawing.Point(210, 10);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(126, 17);
            this.lblRojo.TabIndex = 1;
            this.lblRojo.Text = "🟥 Rojo = Ocupada";
            // 
            // lblNaranja
            // 
            this.lblNaranja.AutoSize = true;
            this.lblNaranja.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNaranja.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblNaranja.Location = new System.Drawing.Point(380, 10);
            this.lblNaranja.Name = "lblNaranja";
            this.lblNaranja.Size = new System.Drawing.Size(157, 17);
            this.lblNaranja.TabIndex = 2;
            this.lblNaranja.Text = "🟧 Naranja = Reservada";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAzul.ForeColor = System.Drawing.Color.FromArgb(93, 173, 226);
            this.lblAzul.Location = new System.Drawing.Point(570, 10);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(130, 17);
            this.lblAzul.TabIndex = 3;
            this.lblAzul.Text = "🟦 Azul = Limpieza";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.flpHabitaciones);
            this.Controls.Add(this.pnlLeyenda);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bávaro Oasis - Tablero de Habitaciones";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlLeyenda.ResumeLayout(false);
            this.pnlLeyenda.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.FlowLayoutPanel flpHabitaciones;
        private System.Windows.Forms.Panel pnlLeyenda;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblNaranja;
        private System.Windows.Forms.Label lblAzul;
    }
}
