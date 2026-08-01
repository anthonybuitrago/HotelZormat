namespace HotelZormat
{
    partial class frmFacturacion
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
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.lblNCFVal = new System.Windows.Forms.Label();
            this.lblNCFLabel = new System.Windows.Forms.Label();
            this.lblFechaVal = new System.Windows.Forms.Label();
            this.lblFechaLabel = new System.Windows.Forms.Label();
            this.lblHuespedVal = new System.Windows.Forms.Label();
            this.lblHuespedLabel = new System.Windows.Forms.Label();
            this.lblHabitacionVal = new System.Windows.Forms.Label();
            this.lblHabitacionLabel = new System.Windows.Forms.Label();
            this.lblSubtotalVal = new System.Windows.Forms.Label();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.lblITBISVal = new System.Windows.Forms.Label();
            this.lblITBISLabel = new System.Windows.Forms.Label();
            this.lblPropinaVal = new System.Windows.Forms.Label();
            this.lblPropinaLabel = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(15, 82, 186);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(460, 50);
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
            this.lblTitulo.Text = "Factura de Consumo Final";
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackColor = System.Drawing.Color.White;
            this.pnlFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFactura.Controls.Add(this.lblTotalVal);
            this.pnlFactura.Controls.Add(this.lblTotalLabel);
            this.pnlFactura.Controls.Add(this.lblPropinaVal);
            this.pnlFactura.Controls.Add(this.lblPropinaLabel);
            this.pnlFactura.Controls.Add(this.lblITBISVal);
            this.pnlFactura.Controls.Add(this.lblITBISLabel);
            this.pnlFactura.Controls.Add(this.lblSubtotalVal);
            this.pnlFactura.Controls.Add(this.lblSubtotalLabel);
            this.pnlFactura.Controls.Add(this.lblHabitacionVal);
            this.pnlFactura.Controls.Add(this.lblHabitacionLabel);
            this.pnlFactura.Controls.Add(this.lblHuespedVal);
            this.pnlFactura.Controls.Add(this.lblHuespedLabel);
            this.pnlFactura.Controls.Add(this.lblFechaVal);
            this.pnlFactura.Controls.Add(this.lblFechaLabel);
            this.pnlFactura.Controls.Add(this.lblNCFVal);
            this.pnlFactura.Controls.Add(this.lblNCFLabel);
            this.pnlFactura.Location = new System.Drawing.Point(20, 65);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(420, 310);
            this.pnlFactura.TabIndex = 1;
            // 
            // lblNCFLabel
            // 
            this.lblNCFLabel.AutoSize = true;
            this.lblNCFLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNCFLabel.Location = new System.Drawing.Point(20, 20);
            this.lblNCFLabel.Name = "lblNCFLabel";
            this.lblNCFLabel.Size = new System.Drawing.Size(38, 17);
            this.lblNCFLabel.TabIndex = 0;
            this.lblNCFLabel.Text = "NCF:";
            // 
            // lblNCFVal
            // 
            this.lblNCFVal.AutoSize = true;
            this.lblNCFVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNCFVal.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblNCFVal.Location = new System.Drawing.Point(160, 18);
            this.lblNCFVal.Name = "lblNCFVal";
            this.lblNCFVal.Size = new System.Drawing.Size(121, 20);
            this.lblNCFVal.TabIndex = 1;
            this.lblNCFVal.Text = "B0200000000";
            // 
            // lblFechaLabel
            // 
            this.lblFechaLabel.AutoSize = true;
            this.lblFechaLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFechaLabel.Location = new System.Drawing.Point(20, 50);
            this.lblFechaLabel.Name = "lblFechaLabel";
            this.lblFechaLabel.Size = new System.Drawing.Size(100, 17);
            this.lblFechaLabel.TabIndex = 2;
            this.lblFechaLabel.Text = "Fecha Emisión:";
            // 
            // lblFechaVal
            // 
            this.lblFechaVal.AutoSize = true;
            this.lblFechaVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFechaVal.Location = new System.Drawing.Point(160, 50);
            this.lblFechaVal.Name = "lblFechaVal";
            this.lblFechaVal.Size = new System.Drawing.Size(126, 17);
            this.lblFechaVal.TabIndex = 3;
            this.lblFechaVal.Text = "00/00/0000 00:00";
            // 
            // lblHuespedLabel
            // 
            this.lblHuespedLabel.AutoSize = true;
            this.lblHuespedLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHuespedLabel.Location = new System.Drawing.Point(20, 80);
            this.lblHuespedLabel.Name = "lblHuespedLabel";
            this.lblHuespedLabel.Size = new System.Drawing.Size(67, 17);
            this.lblHuespedLabel.TabIndex = 4;
            this.lblHuespedLabel.Text = "Huésped:";
            // 
            // lblHuespedVal
            // 
            this.lblHuespedVal.AutoSize = true;
            this.lblHuespedVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHuespedVal.Location = new System.Drawing.Point(160, 80);
            this.lblHuespedVal.Name = "lblHuespedVal";
            this.lblHuespedVal.Size = new System.Drawing.Size(117, 17);
            this.lblHuespedVal.TabIndex = 5;
            this.lblHuespedVal.Text = "Nombre Huésped";
            // 
            // lblHabitacionLabel
            // 
            this.lblHabitacionLabel.AutoSize = true;
            this.lblHabitacionLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHabitacionLabel.Location = new System.Drawing.Point(20, 110);
            this.lblHabitacionLabel.Name = "lblHabitacionLabel";
            this.lblHabitacionLabel.Size = new System.Drawing.Size(78, 17);
            this.lblHabitacionLabel.TabIndex = 6;
            this.lblHabitacionLabel.Text = "Habitaciones:";
            // 
            // lblHabitacionVal
            // 
            this.lblHabitacionVal.AutoSize = true;
            this.lblHabitacionVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHabitacionVal.Location = new System.Drawing.Point(160, 110);
            this.lblHabitacionVal.Name = "lblHabitacionVal";
            this.lblHabitacionVal.Size = new System.Drawing.Size(43, 17);
            this.lblHabitacionVal.TabIndex = 7;
            this.lblHabitacionVal.Text = "#101";
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.AutoSize = true;
            this.lblSubtotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalLabel.Location = new System.Drawing.Point(20, 160);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotalLabel.TabIndex = 8;
            this.lblSubtotalLabel.Text = "Subtotal:";
            // 
            // lblSubtotalVal
            // 
            this.lblSubtotalVal.AutoSize = true;
            this.lblSubtotalVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotalVal.Location = new System.Drawing.Point(160, 160);
            this.lblSubtotalVal.Name = "lblSubtotalVal";
            this.lblSubtotalVal.Size = new System.Drawing.Size(62, 17);
            this.lblSubtotalVal.TabIndex = 9;
            this.lblSubtotalVal.Text = "RD$ 0.00";
            // 
            // lblITBISLabel
            // 
            this.lblITBISLabel.AutoSize = true;
            this.lblITBISLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblITBISLabel.Location = new System.Drawing.Point(20, 190);
            this.lblITBISLabel.Name = "lblITBISLabel";
            this.lblITBISLabel.Size = new System.Drawing.Size(86, 17);
            this.lblITBISLabel.TabIndex = 10;
            this.lblITBISLabel.Text = "ITBIS (18%):";
            // 
            // lblITBISVal
            // 
            this.lblITBISVal.AutoSize = true;
            this.lblITBISVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblITBISVal.Location = new System.Drawing.Point(160, 190);
            this.lblITBISVal.Name = "lblITBISVal";
            this.lblITBISVal.Size = new System.Drawing.Size(62, 17);
            this.lblITBISVal.TabIndex = 11;
            this.lblITBISVal.Text = "RD$ 0.00";
            // 
            // lblPropinaLabel
            // 
            this.lblPropinaLabel.AutoSize = true;
            this.lblPropinaLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPropinaLabel.Location = new System.Drawing.Point(20, 220);
            this.lblPropinaLabel.Name = "lblPropinaLabel";
            this.lblPropinaLabel.Size = new System.Drawing.Size(142, 17);
            this.lblPropinaLabel.TabIndex = 12;
            this.lblPropinaLabel.Text = "Propina Legal (10%):";
            // 
            // lblPropinaVal
            // 
            this.lblPropinaVal.AutoSize = true;
            this.lblPropinaVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPropinaVal.Location = new System.Drawing.Point(160, 220);
            this.lblPropinaVal.Name = "lblPropinaVal";
            this.lblPropinaVal.Size = new System.Drawing.Size(62, 17);
            this.lblPropinaVal.TabIndex = 13;
            this.lblPropinaVal.Text = "RD$ 0.00";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(20, 260);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(130, 21);
            this.lblTotalLabel.TabIndex = 14;
            this.lblTotalLabel.Text = "TOTAL PAGAR:";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(60, 179, 113);
            this.lblTotalVal.Location = new System.Drawing.Point(160, 258);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(89, 25);
            this.lblTotalVal.TabIndex = 15;
            this.lblTotalVal.Text = "RD$ 0.00";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(80, 390);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(140, 35);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "🖨️ Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(100, 110, 120);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(240, 390);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "✖ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 440);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pnlFactura);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bávaro Oasis - Detalle de Factura";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFactura.ResumeLayout(false);
            this.pnlFactura.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Label lblNCFLabel;
        private System.Windows.Forms.Label lblNCFVal;
        private System.Windows.Forms.Label lblFechaLabel;
        private System.Windows.Forms.Label lblFechaVal;
        private System.Windows.Forms.Label lblHuespedLabel;
        private System.Windows.Forms.Label lblHuespedVal;
        private System.Windows.Forms.Label lblHabitacionLabel;
        private System.Windows.Forms.Label lblHabitacionVal;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.Label lblITBISLabel;
        private System.Windows.Forms.Label lblITBISVal;
        private System.Windows.Forms.Label lblPropinaLabel;
        private System.Windows.Forms.Label lblPropinaVal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
    }
}
