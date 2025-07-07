namespace Vistas.VistaPrestamos
{
    partial class FrmAnularPrestamo
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
            this.lblAnularPrestamo = new System.Windows.Forms.Label();
            this.txtNumeroPrestamo = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnularPrestamo
            // 
            this.lblAnularPrestamo.AutoSize = true;
            this.lblAnularPrestamo.Location = new System.Drawing.Point(61, 83);
            this.lblAnularPrestamo.Name = "lblAnularPrestamo";
            this.lblAnularPrestamo.Size = new System.Drawing.Size(106, 13);
            this.lblAnularPrestamo.TabIndex = 0;
            this.lblAnularPrestamo.Text = "Numero de Prestamo";
            // 
            // txtNumeroPrestamo
            // 
            this.txtNumeroPrestamo.Location = new System.Drawing.Point(218, 83);
            this.txtNumeroPrestamo.Name = "txtNumeroPrestamo";
            this.txtNumeroPrestamo.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroPrestamo.TabIndex = 1;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(952, 431);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(103, 30);
            this.btnAnular.TabIndex = 2;
            this.btnAnular.Text = "Anular Prestamo";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(465, 78);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(64, 141);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(1035, 89);
            this.dgvPrestamos.TabIndex = 4;
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Location = new System.Drawing.Point(64, 307);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.Size = new System.Drawing.Size(542, 154);
            this.dgvCuotas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cuotas";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(535, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(143, 24);
            this.txtTitulo.TabIndex = 29;
            this.txtTitulo.Text = "Anular prestamo";
            // 
            // FrmAnularPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 582);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCuotas);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtNumeroPrestamo);
            this.Controls.Add(this.lblAnularPrestamo);
            this.Name = "FrmAnularPrestamo";
            this.Text = "FrmAnularPrestamo";
            this.Load += new System.EventHandler(this.FrmAnularPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnularPrestamo;
        private System.Windows.Forms.TextBox txtNumeroPrestamo;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitulo;
    }
}