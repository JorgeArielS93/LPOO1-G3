namespace Vistas.VistaDestino
{
    partial class FrmAltaDestino
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(26, 84);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(254, 54);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(86, 144);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(126, 32);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Agregar Destino";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(86, 9);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(142, 24);
            this.txtTitulo.TabIndex = 29;
            this.txtTitulo.Text = "Agregar Destino";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(23, 54);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(69, 13);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Descripcion: ";
            // 
            // FrmAltaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 219);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Name = "FrmAltaDestino";
            this.Text = "FrmAltaDestino";
            this.Load += new System.EventHandler(this.FrmAltaDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblDestino;
    }
}