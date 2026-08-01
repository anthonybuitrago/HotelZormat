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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblFiltroPiso = new System.Windows.Forms.Label();
            this.cboFiltroPiso = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.cboPiso = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(840, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión Habitaciones";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Controls.Add(this.cboFiltroEstado);
            this.gbFiltros.Controls.Add(this.lblFiltroEstado);
            this.gbFiltros.Controls.Add(this.cboFiltroPiso);
            this.gbFiltros.Controls.Add(this.lblFiltroPiso);
            this.gbFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(15, 60);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(490, 60);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros en BD";
            // 
            // lblFiltroPiso
            // 
            this.lblFiltroPiso.AutoSize = true;
            this.lblFiltroPiso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroPiso.Location = new System.Drawing.Point(15, 25);
            this.lblFiltroPiso.Name = "lblFiltroPiso";
            this.lblFiltroPiso.Size = new System.Drawing.Size(32, 15);
            this.lblFiltroPiso.TabIndex = 0;
            this.lblFiltroPiso.Text = "Piso:";
            // 
            // cboFiltroPiso
            // 
            this.cboFiltroPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPiso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFiltroPiso.FormattingEnabled = true;
            this.cboFiltroPiso.Location = new System.Drawing.Point(50, 22);
            this.cboFiltroPiso.Name = "cboFiltroPiso";
            this.cboFiltroPiso.Size = new System.Drawing.Size(100, 23);
            this.cboFiltroPiso.TabIndex = 1;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroEstado.Location = new System.Drawing.Point(165, 25);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(45, 15);
            this.lblFiltroEstado.TabIndex = 2;
            this.lblFiltroEstado.Text = "Estado:";
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFiltroEstado.FormattingEnabled = true;
            this.cboFiltroEstado.Location = new System.Drawing.Point(215, 22);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(130, 23);
            this.cboFiltroEstado.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(365, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 27);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "🔍 Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(15, 130);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(490, 310);
            this.dgvHabitaciones.TabIndex = 2;
            this.dgvHabitaciones.SelectionChanged += new System.EventHandler(this.dgvHabitaciones_SelectionChanged);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Controls.Add(this.btnEliminar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.txtTarifa);
            this.gbDatos.Controls.Add(this.lblTarifa);
            this.gbDatos.Controls.Add(this.txtCapacidad);
            this.gbDatos.Controls.Add(this.lblCapacidad);
            this.gbDatos.Controls.Add(this.cboEstado);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.cboPiso);
            this.gbDatos.Controls.Add(this.lblPiso);
            this.gbDatos.Controls.Add(this.cboTipo);
            this.gbDatos.Controls.Add(this.lblTipo);
            this.gbDatos.Controls.Add(this.txtNumero);
            this.gbDatos.Controls.Add(this.lblNumero);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbDatos.Location = new System.Drawing.Point(520, 60);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(305, 380);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de Habitación";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumero.Location = new System.Drawing.Point(15, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNumero.Location = new System.Drawing.Point(100, 27);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(185, 24);
            this.txtNumero.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipo.Location = new System.Drawing.Point(15, 70);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(100, 67);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(185, 25);
            this.cboTipo.TabIndex = 3;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPiso.Location = new System.Drawing.Point(15, 110);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(32, 15);
            this.lblPiso.TabIndex = 4;
            this.lblPiso.Text = "Piso:";
            // 
            // cboPiso
            // 
            this.cboPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPiso.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPiso.FormattingEnabled = true;
            this.cboPiso.Location = new System.Drawing.Point(100, 107);
            this.cboPiso.Name = "cboPiso";
            this.cboPiso.Size = new System.Drawing.Size(185, 25);
            this.cboPiso.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.Location = new System.Drawing.Point(15, 150);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(100, 147);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(185, 25);
            this.cboEstado.TabIndex = 7;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCapacidad.Location = new System.Drawing.Point(15, 190);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(66, 15);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCapacidad.Location = new System.Drawing.Point(100, 187);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(185, 24);
            this.txtCapacidad.TabIndex = 9;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarifa.Location = new System.Drawing.Point(15, 230);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(66, 15);
            this.lblTarifa.TabIndex = 10;
            this.lblTarifa.Text = "Tarifa Base:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTarifa.Location = new System.Drawing.Point(100, 227);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(185, 24);
            this.txtTarifa.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(15, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "➕ Crear";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(155, 275);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 35);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "💾 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(15, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(100, 110, 120);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(155, 325);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmGestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 460);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGestionHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bávaro Oasis - Habitaciones";
            this.Load += new System.EventHandler(this.frmGestionHabitaciones_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblFiltroPiso;
        private System.Windows.Forms.ComboBox cboFiltroPiso;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.ComboBox cboPiso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
