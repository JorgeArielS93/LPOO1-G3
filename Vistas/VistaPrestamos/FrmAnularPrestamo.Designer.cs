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
            this.btnAnular.Location = new System.Drawing.Point(143, 202);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(103, 30);
            this.btnAnular.TabIndex = 2;
            this.btnAnular.Text = "Anular Prestamo";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // FrmAnularPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 344);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtNumeroPrestamo);
            this.Controls.Add(this.lblAnularPrestamo);
            this.Name = "FrmAnularPrestamo";
            this.Text = "FrmAnularPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnularPrestamo;
        private System.Windows.Forms.TextBox txtNumeroPrestamo;
        private System.Windows.Forms.Button btnAnular;
    }
}