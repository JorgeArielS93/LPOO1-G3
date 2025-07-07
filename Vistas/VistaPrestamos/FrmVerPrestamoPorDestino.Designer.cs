namespace Vistas.VistaPrestamos
{
    partial class FrmVerPrestamoPorDestino
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
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOtorgados = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblCancelados = new System.Windows.Forms.Label();
            this.lblAnulados = new System.Windows.Forms.Label();
            this.lblTotalPrestamos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(92, 52);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(283, 24);
            this.cmbDestino.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destino: ";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(501, 52);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(16, 107);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(1339, 350);
            this.dgvPrestamos.TabIndex = 3;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione un destino ";
            // 
            // lblOtorgados
            // 
            this.lblOtorgados.AutoSize = true;
            this.lblOtorgados.Location = new System.Drawing.Point(200, 487);
            this.lblOtorgados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtorgados.Name = "lblOtorgados";
            this.lblOtorgados.Size = new System.Drawing.Size(46, 17);
            this.lblOtorgados.TabIndex = 5;
            this.lblOtorgados.Text = "label3";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(381, 487);
            this.lblPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(46, 17);
            this.lblPendientes.TabIndex = 6;
            this.lblPendientes.Text = "label4";
            // 
            // lblCancelados
            // 
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Location = new System.Drawing.Point(573, 487);
            this.lblCancelados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(46, 17);
            this.lblCancelados.TabIndex = 7;
            this.lblCancelados.Text = "label5";
            // 
            // lblAnulados
            // 
            this.lblAnulados.AutoSize = true;
            this.lblAnulados.Location = new System.Drawing.Point(776, 487);
            this.lblAnulados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulados.Name = "lblAnulados";
            this.lblAnulados.Size = new System.Drawing.Size(46, 17);
            this.lblAnulados.TabIndex = 8;
            this.lblAnulados.Text = "label6";
            // 
            // lblTotalPrestamos
            // 
            this.lblTotalPrestamos.AutoSize = true;
            this.lblTotalPrestamos.Location = new System.Drawing.Point(961, 487);
            this.lblTotalPrestamos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrestamos.Name = "lblTotalPrestamos";
            this.lblTotalPrestamos.Size = new System.Drawing.Size(46, 17);
            this.lblTotalPrestamos.TabIndex = 9;
            this.lblTotalPrestamos.Text = "label7";
            // 
            // FrmVerPrestamoPorDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 550);
            this.Controls.Add(this.lblTotalPrestamos);
            this.Controls.Add(this.lblAnulados);
            this.Controls.Add(this.lblCancelados);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblOtorgados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestino);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVerPrestamoPorDestino";
            this.Text = "FrmVerPrestamoPorDestino";
            this.Load += new System.EventHandler(this.FrmVerPrestamoPorDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOtorgados;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblCancelados;
        private System.Windows.Forms.Label lblAnulados;
        private System.Windows.Forms.Label lblTotalPrestamos;
    }
}