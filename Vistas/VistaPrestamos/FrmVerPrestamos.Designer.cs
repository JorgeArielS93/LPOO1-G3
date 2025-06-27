namespace Vistas.VistaPrestamos
{
    partial class FrmVerPrestamos
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
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbCuotas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDestiny = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 163);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(671, 217);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            this.dgvPrestamos.CurrentCellChanged += new System.EventHandler(this.dgvPrestamos_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prestamos";
            // 
            // dgbCuotas
            // 
            this.dgbCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbCuotas.Location = new System.Drawing.Point(12, 575);
            this.dgbCuotas.Name = "dgbCuotas";
            this.dgbCuotas.Size = new System.Drawing.Size(671, 201);
            this.dgbCuotas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalles del prestamo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(442, 494);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente: Nombre";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(442, 521);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(85, 13);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino: Destino";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(442, 546);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(85, 13);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "Periodo: Periodo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cuotas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESDE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "HASTA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(92, 120);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 11;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(381, 121);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(587, 57);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(96, 52);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "FILTRAR";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DESTINO";
            // 
            // cmbDestiny
            // 
            this.cmbDestiny.FormattingEnabled = true;
            this.cmbDestiny.Location = new System.Drawing.Point(92, 57);
            this.cmbDestiny.Name = "cmbDestiny";
            this.cmbDestiny.Size = new System.Drawing.Size(489, 21);
            this.cmbDestiny.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmVerPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDestiny);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgbCuotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrestamos);
            this.Name = "FrmVerPrestamos";
            this.Text = "FrmVerPrestamos";
            this.Load += new System.EventHandler(this.FrmVerPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgbCuotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDestiny;
        private System.Windows.Forms.Button button1;
    }
}