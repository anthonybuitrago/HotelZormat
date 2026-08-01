namespace HotelZormat
{
    partial class frmReportes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tcReportes = new System.Windows.Forms.TabControl();
            this.tpOcupacion = new System.Windows.Forms.TabPage();
            this.btnCargarOcupacion = new System.Windows.Forms.Button();
            this.dgvOcupacion = new System.Windows.Forms.DataGridView();
            this.tpIngresos = new System.Windows.Forms.TabPage();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarIngresos = new System.Windows.Forms.Button();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.lblTotalIngresosLabel = new System.Windows.Forms.Label();
            this.lblTotalIngresosVal = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tcReportes.SuspendLayout();
            this.tpOcupacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcupacion)).BeginInit();
            this.tpIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(20, 35, 60);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(780, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reportes de Gestión";
            // 
            // tcReportes
            // 
            this.tcReportes.Controls.Add(this.tpOcupacion);
            this.tcReportes.Controls.Add(this.tpIngresos);
            this.tcReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tcReportes.Location = new System.Drawing.Point(0, 50);
            this.tcReportes.Name = "tcReportes";
            this.tcReportes.SelectedIndex = 0;
            this.tcReportes.Size = new System.Drawing.Size(780, 410);
            this.tcReportes.TabIndex = 1;
            // 
            // tpOcupacion
            // 
            this.tpOcupacion.Controls.Add(this.dgvOcupacion);
            this.tpOcupacion.Controls.Add(this.btnCargarOcupacion);
            this.tpOcupacion.Location = new System.Drawing.Point(4, 26);
            this.tpOcupacion.Name = "tpOcupacion";
            this.tpOcupacion.Padding = new System.Windows.Forms.Padding(10);
            this.tpOcupacion.Size = new System.Drawing.Size(772, 380);
            this.tpOcupacion.TabIndex = 0;
            this.tpOcupacion.Text = "🏨 Reporte 1: Ocupación del Día";
            this.tpOcupacion.UseVisualStyleBackColor = true;
            // 
            // btnCargarOcupacion
            // 
            this.btnCargarOcupacion.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnCargarOcupacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarOcupacion.ForeColor = System.Drawing.Color.White;
            this.btnCargarOcupacion.Location = new System.Drawing.Point(10, 10);
            this.btnCargarOcupacion.Name = "btnCargarOcupacion";
            this.btnCargarOcupacion.Size = new System.Drawing.Size(180, 32);
            this.btnCargarOcupacion.TabIndex = 0;
            this.btnCargarOcupacion.Text = "🔄 Cargar Ocupación Hoy";
            this.btnCargarOcupacion.UseVisualStyleBackColor = false;
            this.btnCargarOcupacion.Click += new System.EventHandler(this.btnCargarOcupacion_Click);
            // 
            // dgvOcupacion
            // 
            this.dgvOcupacion.AllowUserToAddRows = false;
            this.dgvOcupacion.AllowUserToDeleteRows = false;
            this.dgvOcupacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOcupacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvOcupacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcupacion.Location = new System.Drawing.Point(10, 50);
            this.dgvOcupacion.Name = "dgvOcupacion";
            this.dgvOcupacion.ReadOnly = true;
            this.dgvOcupacion.Size = new System.Drawing.Size(750, 320);
            this.dgvOcupacion.TabIndex = 1;
            // 
            // tpIngresos
            // 
            this.tpIngresos.Controls.Add(this.lblTotalIngresosVal);
            this.tpIngresos.Controls.Add(this.lblTotalIngresosLabel);
            this.tpIngresos.Controls.Add(this.dgvIngresos);
            this.tpIngresos.Controls.Add(this.btnBuscarIngresos);
            this.tpIngresos.Controls.Add(this.dtpFin);
            this.tpIngresos.Controls.Add(this.lblFechaFin);
            this.tpIngresos.Controls.Add(this.dtpInicio);
            this.tpIngresos.Controls.Add(this.lblFechaInicio);
            this.tpIngresos.Location = new System.Drawing.Point(4, 26);
            this.tpIngresos.Name = "tpIngresos";
            this.tpIngresos.Padding = new System.Windows.Forms.Padding(10);
            this.tpIngresos.Size = new System.Drawing.Size(772, 380);
            this.tpIngresos.TabIndex = 1;
            this.tpIngresos.Text = "💰 Reporte 2: Ingresos por Rango de Fecha";
            this.tpIngresos.UseVisualStyleBackColor = true;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaInicio.Location = new System.Drawing.Point(10, 15);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(73, 15);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(90, 12);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(130, 23);
            this.dtpInicio.TabIndex = 1;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaFin.Location = new System.Drawing.Point(240, 15);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(60, 15);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(310, 12);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(130, 23);
            this.dtpFin.TabIndex = 3;
            // 
            // btnBuscarIngresos
            // 
            this.btnBuscarIngresos.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnBuscarIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarIngresos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarIngresos.Location = new System.Drawing.Point(460, 10);
            this.btnBuscarIngresos.Name = "btnBuscarIngresos";
            this.btnBuscarIngresos.Size = new System.Drawing.Size(120, 28);
            this.btnBuscarIngresos.TabIndex = 4;
            this.btnBuscarIngresos.Text = "📊 Generar";
            this.btnBuscarIngresos.UseVisualStyleBackColor = false;
            this.btnBuscarIngresos.Click += new System.EventHandler(this.btnBuscarIngresos_Click);
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Location = new System.Drawing.Point(10, 48);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            this.dgvIngresos.Size = new System.Drawing.Size(750, 280);
            this.dgvIngresos.TabIndex = 5;
            // 
            // lblTotalIngresosLabel
            // 
            this.lblTotalIngresosLabel.AutoSize = true;
            this.lblTotalIngresosLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalIngresosLabel.Location = new System.Drawing.Point(450, 342);
            this.lblTotalIngresosLabel.Name = "lblTotalIngresosLabel";
            this.lblTotalIngresosLabel.Size = new System.Drawing.Size(134, 20);
            this.lblTotalIngresosLabel.TabIndex = 6;
            this.lblTotalIngresosLabel.Text = "TOTAL INGRESOS:";
            // 
            // lblTotalIngresosVal
            // 
            this.lblTotalIngresosVal.AutoSize = true;
            this.lblTotalIngresosVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalIngresosVal.ForeColor = System.Drawing.Color.FromArgb(60, 179, 113);
            this.lblTotalIngresosVal.Location = new System.Drawing.Point(590, 340);
            this.lblTotalIngresosVal.Name = "lblTotalIngresosVal";
            this.lblTotalIngresosVal.Size = new System.Drawing.Size(77, 21);
            this.lblTotalIngresosVal.TabIndex = 7;
            this.lblTotalIngresosVal.Text = "RD$ 0.00";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.tcReportes);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bávaro Oasis - Reportes del Sistema";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tcReportes.ResumeLayout(false);
            this.tpOcupacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcupacion)).EndInit();
            this.tpIngresos.ResumeLayout(false);
            this.tpIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tcReportes;
        private System.Windows.Forms.TabPage tpOcupacion;
        private System.Windows.Forms.Button btnCargarOcupacion;
        private System.Windows.Forms.DataGridView dgvOcupacion;
        private System.Windows.Forms.TabPage tpIngresos;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnBuscarIngresos;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.Label lblTotalIngresosLabel;
        private System.Windows.Forms.Label lblTotalIngresosVal;
    }
}
