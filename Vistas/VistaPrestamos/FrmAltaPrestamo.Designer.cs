namespace Vistas.VistaPrestamos
{
    partial class FrmAltaPrestamo
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblTasaInteres = new System.Windows.Forms.Label();
            this.lblCantidadCuotas = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtCantidadCuotas = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(41, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(41, 50);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(41, 88);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(86, 13);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Periodo de Pago";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(42, 127);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe";
            // 
            // lblTasaInteres
            // 
            this.lblTasaInteres.AutoSize = true;
            this.lblTasaInteres.Location = new System.Drawing.Point(41, 164);
            this.lblTasaInteres.Name = "lblTasaInteres";
            this.lblTasaInteres.Size = new System.Drawing.Size(81, 13);
            this.lblTasaInteres.TabIndex = 5;
            this.lblTasaInteres.Text = "Tasa de Interes";
            // 
            // lblCantidadCuotas
            // 
            this.lblCantidadCuotas.AutoSize = true;
            this.lblCantidadCuotas.Location = new System.Drawing.Point(42, 204);
            this.lblCantidadCuotas.Name = "lblCantidadCuotas";
            this.lblCantidadCuotas.Size = new System.Drawing.Size(100, 13);
            this.lblCantidadCuotas.TabIndex = 6;
            this.lblCantidadCuotas.Text = "Cantidad de Cuotas";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(243, 19);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 7;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(243, 88);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(200, 21);
            this.cmbPeriodo.TabIndex = 8;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(243, 50);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(200, 21);
            this.cmbDestino.TabIndex = 9;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(243, 124);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(200, 20);
            this.txtImporte.TabIndex = 11;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(243, 161);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(200, 20);
            this.txtTasaInteres.TabIndex = 12;
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.Location = new System.Drawing.Point(243, 201);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(200, 20);
            this.txtCantidadCuotas.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(67, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 388);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidadCuotas);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCantidadCuotas);
            this.Controls.Add(this.lblTasaInteres);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmAltaPrestamo";
            this.Text = "FrmAltaPrestamo";
            this.Load += new System.EventHandler(this.FrmAltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}