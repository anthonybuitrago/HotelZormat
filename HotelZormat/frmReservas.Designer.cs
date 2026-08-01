namespace HotelZormat
{
    partial class frmReservas
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.gbNuevaReserva = new System.Windows.Forms.GroupBox();
            this.lblHuesped = new System.Windows.Forms.Label();
            this.cboHuespedes = new System.Windows.Forms.ComboBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cboHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.lblNochesText = new System.Windows.Forms.Label();
            this.lblNochesCalculadas = new System.Windows.Forms.Label();
            this.lblMontoText = new System.Windows.Forms.Label();
            this.lblMontoCalculado = new System.Windows.Forms.Label();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.lblSubtituloLista = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.gbNuevaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(20, 35, 60);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(860, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Reservaciones";
            // 
            // lblSubtituloLista
            // 
            this.lblSubtituloLista.AutoSize = true;
            this.lblSubtituloLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloLista.ForeColor = System.Drawing.Color.FromArgb(20, 35, 60);
            this.lblSubtituloLista.Location = new System.Drawing.Point(15, 60);
            this.lblSubtituloLista.Name = "lblSubtituloLista";
            this.lblSubtituloLista.Size = new System.Drawing.Size(235, 19);
            this.lblSubtituloLista.TabIndex = 1;
            this.lblSubtituloLista.Text = "📅 Reservas Próximas (7 Días):";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(15, 85);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(490, 370);
            this.dgvReservas.TabIndex = 2;
            // 
            // gbNuevaReserva
            // 
            this.gbNuevaReserva.Controls.Add(this.btnCrearReserva);
            this.gbNuevaReserva.Controls.Add(this.lblMontoCalculado);
            this.gbNuevaReserva.Controls.Add(this.lblMontoText);
            this.gbNuevaReserva.Controls.Add(this.lblNochesCalculadas);
            this.gbNuevaReserva.Controls.Add(this.lblNochesText);
            this.gbNuevaReserva.Controls.Add(this.cboTemporada);
            this.gbNuevaReserva.Controls.Add(this.lblTemporada);
            this.gbNuevaReserva.Controls.Add(this.dtpCheckOut);
            this.gbNuevaReserva.Controls.Add(this.lblCheckOut);
            this.gbNuevaReserva.Controls.Add(this.dtpCheckIn);
            this.gbNuevaReserva.Controls.Add(this.lblCheckIn);
            this.gbNuevaReserva.Controls.Add(this.cboHabitaciones);
            this.gbNuevaReserva.Controls.Add(this.lblHabitacion);
            this.gbNuevaReserva.Controls.Add(this.cboHuespedes);
            this.gbNuevaReserva.Controls.Add(this.lblHuesped);
            this.gbNuevaReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbNuevaReserva.Location = new System.Drawing.Point(520, 60);
            this.gbNuevaReserva.Name = "gbNuevaReserva";
            this.gbNuevaReserva.Size = new System.Drawing.Size(325, 395);
            this.gbNuevaReserva.TabIndex = 3;
            this.gbNuevaReserva.TabStop = false;
            this.gbNuevaReserva.Text = "Crear Nueva Reserva";
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHuesped.Location = new System.Drawing.Point(15, 30);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(57, 15);
            this.lblHuesped.TabIndex = 0;
            this.lblHuesped.Text = "Huésped:";
            // 
            // cboHuespedes
            // 
            this.cboHuespedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuespedes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHuespedes.FormattingEnabled = true;
            this.cboHuespedes.Location = new System.Drawing.Point(105, 27);
            this.cboHuespedes.Name = "cboHuespedes";
            this.cboHuespedes.Size = new System.Drawing.Size(200, 25);
            this.cboHuespedes.TabIndex = 1;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHabitacion.Location = new System.Drawing.Point(15, 70);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(68, 15);
            this.lblHabitacion.TabIndex = 2;
            this.lblHabitacion.Text = "Habitacion:";
            // 
            // cboHabitaciones
            // 
            this.cboHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHabitaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHabitaciones.FormattingEnabled = true;
            this.cboHabitaciones.Location = new System.Drawing.Point(105, 67);
            this.cboHabitaciones.Name = "cboHabitaciones";
            this.cboHabitaciones.Size = new System.Drawing.Size(200, 25);
            this.cboHabitaciones.TabIndex = 3;
            this.cboHabitaciones.SelectedIndexChanged += new System.EventHandler(this.CalcularReserva_Event);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckIn.Location = new System.Drawing.Point(15, 115);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(57, 15);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "Check-In:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(105, 110);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 24);
            this.dtpCheckIn.TabIndex = 5;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.CalcularReserva_Event);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckOut.Location = new System.Drawing.Point(15, 155);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(67, 15);
            this.lblCheckOut.TabIndex = 6;
            this.lblCheckOut.Text = "Check-Out:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(105, 150);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 24);
            this.dtpCheckOut.TabIndex = 7;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.CalcularReserva_Event);
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTemporada.Location = new System.Drawing.Point(15, 195);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(69, 15);
            this.lblTemporada.TabIndex = 8;
            this.lblTemporada.Text = "Temporada:";
            // 
            // cboTemporada
            // 
            this.cboTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemporada.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(105, 192);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(200, 25);
            this.cboTemporada.TabIndex = 9;
            this.cboTemporada.SelectedIndexChanged += new System.EventHandler(this.CalcularReserva_Event);
            // 
            // lblNochesText
            // 
            this.lblNochesText.AutoSize = true;
            this.lblNochesText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNochesText.Location = new System.Drawing.Point(15, 240);
            this.lblNochesText.Name = "lblNochesText";
            this.lblNochesText.Size = new System.Drawing.Size(77, 15);
            this.lblNochesText.TabIndex = 10;
            this.lblNochesText.Text = "Total Noches:";
            // 
            // lblNochesCalculadas
            // 
            this.lblNochesCalculadas.AutoSize = true;
            this.lblNochesCalculadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNochesCalculadas.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblNochesCalculadas.Location = new System.Drawing.Point(105, 236);
            this.lblNochesCalculadas.Name = "lblNochesCalculadas";
            this.lblNochesCalculadas.Size = new System.Drawing.Size(18, 20);
            this.lblNochesCalculadas.TabIndex = 11;
            this.lblNochesCalculadas.Text = "0";
            // 
            // lblMontoText
            // 
            this.lblMontoText.AutoSize = true;
            this.lblMontoText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMontoText.Location = new System.Drawing.Point(15, 275);
            this.lblMontoText.Name = "lblMontoText";
            this.lblMontoText.Size = new System.Drawing.Size(75, 15);
            this.lblMontoText.TabIndex = 12;
            this.lblMontoText.Text = "Monto Total:";
            // 
            // lblMontoCalculado
            // 
            this.lblMontoCalculado.AutoSize = true;
            this.lblMontoCalculado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMontoCalculado.ForeColor = System.Drawing.Color.FromArgb(60, 179, 113);
            this.lblMontoCalculado.Location = new System.Drawing.Point(105, 270);
            this.lblMontoCalculado.Name = "lblMontoCalculado";
            this.lblMontoCalculado.Size = new System.Drawing.Size(68, 21);
            this.lblMontoCalculado.TabIndex = 13;
            this.lblMontoCalculado.Text = "RD$ 0.00";
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.FromArgb(60, 179, 113);
            this.btnCrearReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReserva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrearReserva.ForeColor = System.Drawing.Color.White;
            this.btnCrearReserva.Location = new System.Drawing.Point(15, 330);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(290, 45);
            this.btnCrearReserva.TabIndex = 14;
            this.btnCrearReserva.Text = "✅ Confirmar Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.btnCrearReserva_Click);
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.gbNuevaReserva);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.lblSubtituloLista);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bávaro Oasis - Gestión de Reservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.gbNuevaReserva.ResumeLayout(false);
            this.gbNuevaReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtituloLista;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.GroupBox gbNuevaReserva;
        private System.Windows.Forms.Label lblHuesped;
        private System.Windows.Forms.ComboBox cboHuespedes;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cboHabitaciones;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.Label lblNochesText;
        private System.Windows.Forms.Label lblNochesCalculadas;
        private System.Windows.Forms.Label lblMontoText;
        private System.Windows.Forms.Label lblMontoCalculado;
        private System.Windows.Forms.Button btnCrearReserva;
    }
}
