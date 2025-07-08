namespace Vistas.VistaPago
{
    partial class FrmVerPagoPorFechaCliente
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
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.txtCliTitle = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.txtDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantidadPagos = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(344, 84);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(203, 21);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // txtCliTitle
            // 
            this.txtCliTitle.AutoSize = true;
            this.txtCliTitle.Location = new System.Drawing.Point(393, 68);
            this.txtCliTitle.Name = "txtCliTitle";
            this.txtCliTitle.Size = new System.Drawing.Size(109, 13);
            this.txtCliTitle.TabIndex = 1;
            this.txtCliTitle.Text = "Seleccione un cliente";
            this.txtCliTitle.Click += new System.EventHandler(this.txtCliTitle_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(223, 122);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(518, 122);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // txtDesde
            // 
            this.txtDesde.AutoSize = true;
            this.txtDesde.Location = new System.Drawing.Point(180, 125);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(38, 13);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.Text = "Desde";
            // 
            // txtHasta
            // 
            this.txtHasta.AutoSize = true;
            this.txtHasta.Location = new System.Drawing.Point(480, 126);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(35, 13);
            this.txtHasta.TabIndex = 5;
            this.txtHasta.Text = "Hasta";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(297, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(354, 22);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.Text = "Pagos de un cliente en un rango de fechas";
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(78, 179);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(771, 209);
            this.dgvPagos.TabIndex = 7;
            this.dgvPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(415, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCantidadPagos
            // 
            this.lblCantidadPagos.AutoSize = true;
            this.lblCantidadPagos.Location = new System.Drawing.Point(201, 413);
            this.lblCantidadPagos.Name = "lblCantidadPagos";
            this.lblCantidadPagos.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadPagos.TabIndex = 9;
            this.lblCantidadPagos.Text = "label1";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Location = new System.Drawing.Point(661, 413);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPagado.TabIndex = 10;
            this.lblTotalPagado.Text = "label1";
            // 
            // FrmVerPagoPorFechaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 488);
            this.Controls.Add(this.lblTotalPagado);
            this.Controls.Add(this.lblCantidadPagos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtCliTitle);
            this.Controls.Add(this.cmbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVerPagoPorFechaCliente";
            this.Text = "FrmVerPagoPorFechaCliente";
            this.Load += new System.EventHandler(this.FrmVerPagoPorFechaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label txtCliTitle;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label txtDesde;
        private System.Windows.Forms.Label txtHasta;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidadPagos;
        private System.Windows.Forms.Label lblTotalPagado;
    }
}