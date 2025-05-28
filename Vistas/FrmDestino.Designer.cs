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
            this.Codigo.Location = new System.Drawing.Point(278, 56);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(263, 150);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtDescripcionDest
            // 
            this.txtDescripcionDest.Location = new System.Drawing.Point(104, 199);
            this.txtDescripcionDest.Multiline = true;
            this.txtDescripcionDest.Name = "txtDescripcionDest";
            this.txtDescripcionDest.Size = new System.Drawing.Size(400, 177);
            this.txtDescripcionDest.TabIndex = 3;
            // 
            // btnGuardarDestino
            // 
            this.btnGuardarDestino.Location = new System.Drawing.Point(393, 438);
            this.btnGuardarDestino.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDestino.Name = "btnGuardarDestino";
            this.btnGuardarDestino.Size = new System.Drawing.Size(166, 30);
            this.btnGuardarDestino.TabIndex = 4;
            this.btnGuardarDestino.Text = "Guardar Destino";
            this.btnGuardarDestino.UseVisualStyleBackColor = true;
            this.btnGuardarDestino.Click += new System.EventHandler(this.btnGuardarDestino_Click);
            this.btnGuardarDestino.MouseHover += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(58, 438);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 30);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCodDestino
            // 
            this.txtCodDestino.Location = new System.Drawing.Point(246, 100);
            this.txtCodDestino.Name = "txtCodDestino";
            this.txtCodDestino.ReadOnly = true;
            this.txtCodDestino.Size = new System.Drawing.Size(116, 22);
            this.txtCodDestino.TabIndex = 6;
            // 
            // FrmDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 506);
            this.Controls.Add(this.txtCodDestino);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarDestino);
            this.Controls.Add(this.txtDescripcionDest);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Codigo);
            this.Name = "FrmDestino";
            this.Text = "FrmDestino";
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