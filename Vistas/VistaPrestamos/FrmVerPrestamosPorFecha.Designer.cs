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
            this.txtTitulo.Location = new System.Drawing.Point(609, 28);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(276, 28);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Ingrese fecha de busqueda";
            this.txtTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.AutoSize = true;
            this.txtDesde.Location = new System.Drawing.Point(380, 105);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(49, 17);
            this.txtDesde.TabIndex = 1;
            this.txtDesde.Text = "Desde";
            // 
            // txtHasta
            // 
            this.txtHasta.AutoSize = true;
            this.txtHasta.Location = new System.Drawing.Point(740, 105);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(45, 17);
            this.txtHasta.TabIndex = 2;
            this.txtHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(433, 101);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(279, 22);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(789, 101);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(280, 22);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(687, 148);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPrestamosFecha
            // 
            this.dgvPrestamosFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosFecha.Location = new System.Drawing.Point(27, 191);
            this.dgvPrestamosFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrestamosFecha.Name = "dgvPrestamosFecha";
            this.dgvPrestamosFecha.Size = new System.Drawing.Size(1359, 281);
            this.dgvPrestamosFecha.TabIndex = 6;
            this.dgvPrestamosFecha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamosFecha_CellContentClick);
            // 
            // lblOtorgados
            // 
            this.lblOtorgados.AutoSize = true;
            this.lblOtorgados.Location = new System.Drawing.Point(215, 500);
            this.lblOtorgados.Name = "lblOtorgados";
            this.lblOtorgados.Size = new System.Drawing.Size(46, 17);
            this.lblOtorgados.TabIndex = 7;
            this.lblOtorgados.Text = "label1";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(414, 500);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(46, 17);
            this.lblPendientes.TabIndex = 8;
            this.lblPendientes.Text = "label2";
            // 
            // lblCancelados
            // 
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Location = new System.Drawing.Point(624, 500);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(46, 17);
            this.lblCancelados.TabIndex = 9;
            this.lblCancelados.Text = "label3";
            // 
            // lblAnulados
            // 
            this.lblAnulados.AutoSize = true;
            this.lblAnulados.Location = new System.Drawing.Point(839, 500);
            this.lblAnulados.Name = "lblAnulados";
            this.lblAnulados.Size = new System.Drawing.Size(46, 17);
            this.lblAnulados.TabIndex = 10;
            this.lblAnulados.Text = "label4";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1038, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label5";
            // 
            // FrmVerPrestamosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 553);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVerPrestamosPorFecha";
            this.Text = "t";
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