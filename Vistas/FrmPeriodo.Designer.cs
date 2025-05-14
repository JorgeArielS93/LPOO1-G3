namespace Vistas
{
    partial class FrmPeriodo
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarPeriodo = new System.Windows.Forms.Button();
            this.txtDescripcionPer = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtCodPeriodo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(57, 429);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 30);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarPeriodo
            // 
            this.btnGuardarPeriodo.Location = new System.Drawing.Point(416, 429);
            this.btnGuardarPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPeriodo.Name = "btnGuardarPeriodo";
            this.btnGuardarPeriodo.Size = new System.Drawing.Size(142, 30);
            this.btnGuardarPeriodo.TabIndex = 10;
            this.btnGuardarPeriodo.Text = "Guardar Periodo";
            this.btnGuardarPeriodo.UseVisualStyleBackColor = true;
            this.btnGuardarPeriodo.Click += new System.EventHandler(this.btnGuardarPeriodo_Click);
            // 
            // txtDescripcionPer
            // 
            this.txtDescripcionPer.Location = new System.Drawing.Point(93, 190);
            this.txtDescripcionPer.Multiline = true;
            this.txtDescripcionPer.Name = "txtDescripcionPer";
            this.txtDescripcionPer.Size = new System.Drawing.Size(400, 177);
            this.txtDescripcionPer.TabIndex = 9;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(252, 141);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Descripcion.TabIndex = 8;
            this.Descripcion.Text = "Descripcion";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(267, 47);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 6;
            this.Codigo.Text = "Codigo";
            // 
            // txtCodPeriodo
            // 
            this.txtCodPeriodo.Location = new System.Drawing.Point(243, 100);
            this.txtCodPeriodo.Name = "txtCodPeriodo";
            this.txtCodPeriodo.ReadOnly = true;
            this.txtCodPeriodo.Size = new System.Drawing.Size(100, 22);
            this.txtCodPeriodo.TabIndex = 12;
            // 
            // FrmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 506);
            this.Controls.Add(this.txtCodPeriodo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarPeriodo);
            this.Controls.Add(this.txtDescripcionPer);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Codigo);
            this.Name = "FrmPeriodo";
            this.Text = "FrmPeriodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarPeriodo;
        private System.Windows.Forms.TextBox txtDescripcionPer;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox txtCodPeriodo;
    }
}