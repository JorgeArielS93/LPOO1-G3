namespace Vistas.VistaPrestamos
{
    partial class FrmVerPrestamosPorFecha
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPrestamosFecha = new System.Windows.Forms.DataGridView();
            this.lblOtorgados = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblCancelados = new System.Windows.Forms.Label();
            this.lblAnulados = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(457, 23);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(229, 24);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Ingrese fecha de busqueda";
            this.txtTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.AutoSize = true;
            this.txtDesde.Location = new System.Drawing.Point(285, 85);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(38, 13);
            this.txtDesde.TabIndex = 1;
            this.txtDesde.Text = "Desde";
            // 
            // txtHasta
            // 
            this.txtHasta.AutoSize = true;
            this.txtHasta.Location = new System.Drawing.Point(555, 85);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(35, 13);
            this.txtHasta.TabIndex = 2;
            this.txtHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(325, 82);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(210, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(592, 82);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(211, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(515, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPrestamosFecha
            // 
            this.dgvPrestamosFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosFecha.Location = new System.Drawing.Point(20, 155);
            this.dgvPrestamosFecha.Name = "dgvPrestamosFecha";
            this.dgvPrestamosFecha.Size = new System.Drawing.Size(1019, 228);
            this.dgvPrestamosFecha.TabIndex = 6;
            this.dgvPrestamosFecha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamosFecha_CellContentClick);
            // 
            // lblOtorgados
            // 
            this.lblOtorgados.AutoSize = true;
            this.lblOtorgados.Location = new System.Drawing.Point(161, 406);
            this.lblOtorgados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtorgados.Name = "lblOtorgados";
            this.lblOtorgados.Size = new System.Drawing.Size(35, 13);
            this.lblOtorgados.TabIndex = 7;
            this.lblOtorgados.Text = "label1";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(310, 406);
            this.lblPendientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(35, 13);
            this.lblPendientes.TabIndex = 8;
            this.lblPendientes.Text = "label2";
            // 
            // lblCancelados
            // 
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Location = new System.Drawing.Point(468, 406);
            this.lblCancelados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(35, 13);
            this.lblCancelados.TabIndex = 9;
            this.lblCancelados.Text = "label3";
            // 
            // lblAnulados
            // 
            this.lblAnulados.AutoSize = true;
            this.lblAnulados.Location = new System.Drawing.Point(629, 406);
            this.lblAnulados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnulados.Name = "lblAnulados";
            this.lblAnulados.Size = new System.Drawing.Size(35, 13);
            this.lblAnulados.TabIndex = 10;
            this.lblAnulados.Text = "label4";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(778, 406);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label5";
            // 
            // FrmVerPrestamosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 449);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAnulados);
            this.Controls.Add(this.lblCancelados);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblOtorgados);
            this.Controls.Add(this.dgvPrestamosFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtTitulo);
            this.Name = "FrmVerPrestamosPorFecha";
            this.Text = "Ver prestamos por fecha";
            this.Load += new System.EventHandler(this.FrmVerPrestamosPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label txtDesde;
        private System.Windows.Forms.Label txtHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPrestamosFecha;
        private System.Windows.Forms.Label lblOtorgados;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblCancelados;
        private System.Windows.Forms.Label lblAnulados;
        private System.Windows.Forms.Label lblTotal;
    }
}