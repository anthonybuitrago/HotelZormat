namespace HotelZormat
{
    partial class frmGestionHabitaciones
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

        private void InitializeComponent()
        {
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboAccion = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(23, 27);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 24);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            
            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcono.Location = new System.Drawing.Point(161, 24);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(32, 31);
            this.lblIcono.TabIndex = 1;
            this.lblIcono.Text = "?";
            
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(213, 33);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(49, 16);
            this.lblTarifa.TabIndex = 13;
            this.lblTarifa.Text = "$ 0.00";
            
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.ItemHeight = 16;
            this.lstHabitaciones.Location = new System.Drawing.Point(23, 76);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(262, 148);
            this.lstHabitaciones.TabIndex = 8;
            
            this.txtBuscar.Location = new System.Drawing.Point(322, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 5;
            
            this.btnBuscar.Location = new System.Drawing.Point(438, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(317, 76);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(89, 25);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            
            this.btnCheckIn.Location = new System.Drawing.Point(322, 114);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(95, 30);
            this.btnCheckIn.TabIndex = 9;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            
            this.btnCheckOut.Location = new System.Drawing.Point(423, 114);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(95, 30);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            
            this.btnLimpiar.Location = new System.Drawing.Point(322, 150);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            
            this.btnMantenimiento.Location = new System.Drawing.Point(423, 150);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(95, 30);
            this.btnMantenimiento.TabIndex = 12;
            this.btnMantenimiento.Text = "Mant.";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            
            this.cboAccion.FormattingEnabled = true;
            this.cboAccion.Items.AddRange(new object[] {
            "Check-In",
            "Check-Out",
            "Limpiar",
            "Mantenimiento"});
            this.cboAccion.Location = new System.Drawing.Point(23, 245);
            this.cboAccion.Name = "cboAccion";
            this.cboAccion.Size = new System.Drawing.Size(149, 24);
            this.cboAccion.TabIndex = 3;
            
            this.btnConfirmar.Location = new System.Drawing.Point(178, 244);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 26);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            
            this.btnGuardar.Location = new System.Drawing.Point(410, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 38);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            
            this.ClientSize = new System.Drawing.Size(553, 308);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cboAccion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIcono);
            this.Controls.Add(this.cboTipo);
            this.Name = "frmGestionHabitaciones";
            this.Text = "Gestión de Habitaciones";
            this.Load += new System.EventHandler(this.frmGestionHabitaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboAccion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Label lblTarifa;
    }
}