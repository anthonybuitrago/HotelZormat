namespace HotelZormat
{
    partial class FrmPrincipal
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnHuespedes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnCheckInOut = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.pnlTop.Controls.Add(this.lblUsuarioActivo);
            this.pnlTop.Controls.Add(this.lblTituloApp);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(780, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioActivo.AutoSize = false;
            this.lblUsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(220, 230, 242);
            this.lblUsuarioActivo.Location = new System.Drawing.Point(360, 20);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(400, 19);
            this.lblUsuarioActivo.TabIndex = 1;
            this.lblUsuarioActivo.Text = "Usuario: Cargando...";
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblTituloApp.Location = new System.Drawing.Point(20, 15);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(269, 30);
            this.lblTituloApp.TabIndex = 0;
            this.lblTituloApp.Text = "Bávaro Oasis Boutique Hotel";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(40, 90);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "📊 Tablero Habitaciones";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnHabitaciones.Location = new System.Drawing.Point(285, 90);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(210, 60);
            this.btnHabitaciones.TabIndex = 2;
            this.btnHabitaciones.Text = "🛏️ Gestión Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnHuespedes
            // 
            this.btnHuespedes.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuespedes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuespedes.ForeColor = System.Drawing.Color.White;
            this.btnHuespedes.Location = new System.Drawing.Point(530, 90);
            this.btnHuespedes.Name = "btnHuespedes";
            this.btnHuespedes.Size = new System.Drawing.Size(210, 60);
            this.btnHuespedes.TabIndex = 3;
            this.btnHuespedes.Text = "👥 Gestión Huéspedes";
            this.btnHuespedes.UseVisualStyleBackColor = false;
            this.btnHuespedes.Click += new System.EventHandler(this.btnHuespedes_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Location = new System.Drawing.Point(40, 175);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(210, 60);
            this.btnReservas.TabIndex = 4;
            this.btnReservas.Text = "📅 Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheckInOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckInOut.Location = new System.Drawing.Point(285, 175);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(210, 60);
            this.btnCheckInOut.TabIndex = 5;
            this.btnCheckInOut.Text = "🔑 Check-In / Check-Out";
            this.btnCheckInOut.UseVisualStyleBackColor = false;
            this.btnCheckInOut.Click += new System.EventHandler(this.btnCheckInOut_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(530, 175);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(210, 60);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "📈 Reportes de Gestión";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(120, 40, 140);
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.Location = new System.Drawing.Point(40, 260);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(455, 50);
            this.btnBitacora.TabIndex = 7;
            this.btnBitacora.Text = "📜 Bitácora de Acciones (Solo Admin)";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(530, 260);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(210, 50);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "🚪 Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(780, 340);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnCheckInOut);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnHuespedes);
            this.Controls.Add(this.btnHabitaciones);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bávaro Oasis - Sistema Principal";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnHuespedes;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnCheckInOut;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
