namespace Vistas.VistaCuotas
{
    partial class FrmVerCuotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblImportePendiente = new System.Windows.Forms.Label();
            this.lblImportePagado = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblPagadas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.cbNPrestamo = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(182, 147);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(109, 13);
            this.lblDNI.TabIndex = 27;
            this.lblDNI.Text = "Seleccione un cliente";
            // 
            // lblImportePendiente
            // 
            this.lblImportePendiente.AutoSize = true;
            this.lblImportePendiente.Location = new System.Drawing.Point(471, 493);
            this.lblImportePendiente.Name = "lblImportePendiente";
            this.lblImportePendiente.Size = new System.Drawing.Size(99, 13);
            this.lblImportePendiente.TabIndex = 26;
            this.lblImportePendiente.Text = "Importe Pendiente: ";
            // 
            // lblImportePagado
            // 
            this.lblImportePagado.AutoSize = true;
            this.lblImportePagado.Location = new System.Drawing.Point(316, 493);
            this.lblImportePagado.Name = "lblImportePagado";
            this.lblImportePagado.Size = new System.Drawing.Size(88, 13);
            this.lblImportePagado.TabIndex = 25;
            this.lblImportePagado.Text = "Importe Pagado: ";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(177, 493);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(99, 13);
            this.lblPendientes.TabIndex = 24;
            this.lblPendientes.Text = "Cuotas Pendientes:";
            // 
            // lblPagadas
            // 
            this.lblPagadas.AutoSize = true;
            this.lblPagadas.Location = new System.Drawing.Point(44, 493);
            this.lblPagadas.Name = "lblPagadas";
            this.lblPagadas.Size = new System.Drawing.Size(91, 13);
            this.lblPagadas.TabIndex = 23;
            this.lblPagadas.Text = "Cuotas Pagadas: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cuotas";
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Location = new System.Drawing.Point(96, 221);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.Size = new System.Drawing.Size(444, 233);
            this.dgvCuotas.TabIndex = 21;
            // 
            // cbNPrestamo
            // 
            this.cbNPrestamo.FormattingEnabled = true;
            this.cbNPrestamo.Location = new System.Drawing.Point(182, 113);
            this.cbNPrestamo.Name = "cbNPrestamo";
            this.cbNPrestamo.Size = new System.Drawing.Size(121, 21);
            this.cbNPrestamo.TabIndex = 20;
            this.cbNPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbNPrestamo_SelectedIndexChanged);
            this.cbNPrestamo.SelectedValueChanged += new System.EventHandler(this.cbNPrestamo_SelectedValueChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(182, 72);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 19;
            this.cbCliente.SelectedValueChanged += new System.EventHandler(this.cbCliente_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prestamo N°:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(164, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(352, 24);
            this.txtTitulo.TabIndex = 28;
            this.txtTitulo.Text = "Seleccione un cliente y un N° de Prestamo";
            // 
            // FrmVerCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 539);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblImportePendiente);
            this.Controls.Add(this.lblImportePagado);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblPagadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCuotas);
            this.Controls.Add(this.cbNPrestamo);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerCuotas";
            this.Text = "FrmVerCuotas";
            this.Load += new System.EventHandler(this.FrmVerCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblImportePendiente;
        private System.Windows.Forms.Label lblImportePagado;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblPagadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.ComboBox cbNPrestamo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitulo;
    }
}