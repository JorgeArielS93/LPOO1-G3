namespace Vistas
{
    partial class FrmDestino
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
            this.Codigo = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDescripcionDest = new System.Windows.Forms.TextBox();
            this.btnGuardarDestino = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCodDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(208, 46);
            this.Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(197, 122);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtDescripcionDest
            // 
            this.txtDescripcionDest.Location = new System.Drawing.Point(78, 162);
            this.txtDescripcionDest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcionDest.Multiline = true;
            this.txtDescripcionDest.Name = "txtDescripcionDest";
            this.txtDescripcionDest.Size = new System.Drawing.Size(301, 145);
            this.txtDescripcionDest.TabIndex = 3;
            // 
            // btnGuardarDestino
            // 
            this.btnGuardarDestino.Location = new System.Drawing.Point(295, 356);
            this.btnGuardarDestino.Name = "btnGuardarDestino";
            this.btnGuardarDestino.Size = new System.Drawing.Size(124, 24);
            this.btnGuardarDestino.TabIndex = 4;
            this.btnGuardarDestino.Text = "Guardar Destino";
            this.btnGuardarDestino.UseVisualStyleBackColor = true;
            this.btnGuardarDestino.Click += new System.EventHandler(this.btnGuardarDestino_Click);
            this.btnGuardarDestino.MouseHover += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(44, 356);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(72, 24);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCodDestino
            // 
            this.txtCodDestino.Location = new System.Drawing.Point(184, 81);
            this.txtCodDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodDestino.Name = "txtCodDestino";
            this.txtCodDestino.ReadOnly = true;
            this.txtCodDestino.Size = new System.Drawing.Size(88, 20);
            this.txtCodDestino.TabIndex = 6;
            // 
            // FrmDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 411);
            this.Controls.Add(this.txtCodDestino);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarDestino);
            this.Controls.Add(this.txtDescripcionDest);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Codigo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDestino";
            this.Text = "FrmDestino";
            this.Load += new System.EventHandler(this.FrmDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtDescripcionDest;
        private System.Windows.Forms.Button btnGuardarDestino;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtCodDestino;
    }
}