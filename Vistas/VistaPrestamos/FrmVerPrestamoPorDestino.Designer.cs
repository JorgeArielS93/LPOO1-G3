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
            this.lblOtorgados = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblCancelados = new System.Windows.Forms.Label();
            this.lblAnulados = new System.Windows.Forms.Label();
            this.lblTotalPrestamos = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(69, 42);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(213, 21);
            this.cmbDestino.TabIndex = 0;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destino: ";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(376, 42);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 87);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(1004, 284);
            this.dgvPrestamos.TabIndex = 3;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // lblOtorgados
            // 
            this.lblOtorgados.AutoSize = true;
            this.lblOtorgados.Location = new System.Drawing.Point(150, 396);
            this.lblOtorgados.Name = "lblOtorgados";
            this.lblOtorgados.Size = new System.Drawing.Size(35, 13);
            this.lblOtorgados.TabIndex = 5;
            this.lblOtorgados.Text = "label3";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(286, 396);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(35, 13);
            this.lblPendientes.TabIndex = 6;
            this.lblPendientes.Text = "label4";
            // 
            // lblCancelados
            // 
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Location = new System.Drawing.Point(430, 396);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(35, 13);
            this.lblCancelados.TabIndex = 7;
            this.lblCancelados.Text = "label5";
            // 
            // lblAnulados
            // 
            this.lblAnulados.AutoSize = true;
            this.lblAnulados.Location = new System.Drawing.Point(582, 396);
            this.lblAnulados.Name = "lblAnulados";
            this.lblAnulados.Size = new System.Drawing.Size(35, 13);
            this.lblAnulados.TabIndex = 8;
            this.lblAnulados.Text = "label6";
            // 
            // lblTotalPrestamos
            // 
            this.lblTotalPrestamos.AutoSize = true;
            this.lblTotalPrestamos.Location = new System.Drawing.Point(721, 396);
            this.lblTotalPrestamos.Name = "lblTotalPrestamos";
            this.lblTotalPrestamos.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPrestamos.TabIndex = 9;
            this.lblTotalPrestamos.Text = "label7";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(429, 9);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(188, 24);
            this.txtTitulo.TabIndex = 29;
            this.txtTitulo.Text = "Seleccione un destino";
            // 
            // FrmVerPrestamoPorDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 447);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTotalPrestamos);
            this.Controls.Add(this.lblAnulados);
            this.Controls.Add(this.lblCancelados);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblOtorgados);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestino);
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
        private System.Windows.Forms.Label lblOtorgados;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblCancelados;
        private System.Windows.Forms.Label lblAnulados;
        private System.Windows.Forms.Label lblTotalPrestamos;
        private System.Windows.Forms.Label txtTitulo;
    }
}