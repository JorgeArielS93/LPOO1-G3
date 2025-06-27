﻿namespace Vistas.VistaPago
 {
     partial class FrmAltaPago
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
             this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
             this.cmbClientes = new System.Windows.Forms.ComboBox();
             this.cmbPrestamos = new System.Windows.Forms.ComboBox();
             this.dgvCuotas = new System.Windows.Forms.DataGridView();
             this.btnGuardarPago = new System.Windows.Forms.Button();
             this.lblFecha = new System.Windows.Forms.Label();
             this.lblClientes = new System.Windows.Forms.Label();
             this.lblPrestamos = new System.Windows.Forms.Label();
             this.lblCuotas = new System.Windows.Forms.Label();
             ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
             this.SuspendLayout();
             // 
             // dtpFechaPago
             // 
             this.dtpFechaPago.Location = new System.Drawing.Point(164, 24);
             this.dtpFechaPago.Name = "dtpFechaPago";
             this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
             this.dtpFechaPago.TabIndex = 0;
             // 
             // cmbClientes
             // 
             this.cmbClientes.FormattingEnabled = true;
             this.cmbClientes.Location = new System.Drawing.Point(164, 66);
             this.cmbClientes.Name = "cmbClientes";
             this.cmbClientes.Size = new System.Drawing.Size(121, 21);
             this.cmbClientes.TabIndex = 1;
             this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
             // 
             // cmbPrestamos
             // 
             this.cmbPrestamos.FormattingEnabled = true;
             this.cmbPrestamos.Location = new System.Drawing.Point(164, 106);
             this.cmbPrestamos.Name = "cmbPrestamos";
             this.cmbPrestamos.Size = new System.Drawing.Size(121, 21);
             this.cmbPrestamos.TabIndex = 2;
             this.cmbPrestamos.SelectedIndexChanged += new System.EventHandler(this.cmbPrestamos_SelectedIndexChanged);
             // 
             // dgvCuotas
             // 
             this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
             this.dgvCuotas.Location = new System.Drawing.Point(164, 142);
             this.dgvCuotas.Name = "dgvCuotas";
             this.dgvCuotas.Size = new System.Drawing.Size(472, 193);
             this.dgvCuotas.TabIndex = 3;
             // 
             // btnGuardarPago
             // 
             this.btnGuardarPago.Location = new System.Drawing.Point(529, 381);
             this.btnGuardarPago.Name = "btnGuardarPago";
             this.btnGuardarPago.Size = new System.Drawing.Size(107, 23);
             this.btnGuardarPago.TabIndex = 4;
             this.btnGuardarPago.Text = "Pagar";
             this.btnGuardarPago.UseVisualStyleBackColor = true;
             this.btnGuardarPago.Click += new System.EventHandler(this.btnGuardarPago_Click);
             // 
             // lblFecha
             // 
             this.lblFecha.AutoSize = true;
             this.lblFecha.Location = new System.Drawing.Point(24, 30);
             this.lblFecha.Name = "lblFecha";
             this.lblFecha.Size = new System.Drawing.Size(83, 13);
             this.lblFecha.TabIndex = 5;
             this.lblFecha.Text = "Fecha de Pago:";
             // 
             // lblClientes
             // 
             this.lblClientes.AutoSize = true;
             this.lblClientes.Location = new System.Drawing.Point(24, 69);
             this.lblClientes.Name = "lblClientes";
             this.lblClientes.Size = new System.Drawing.Size(45, 13);
             this.lblClientes.TabIndex = 6;
             this.lblClientes.Text = "Cliente: ";
             // 
             // lblPrestamos
             // 
             this.lblPrestamos.AutoSize = true;
             this.lblPrestamos.Location = new System.Drawing.Point(24, 114);
             this.lblPrestamos.Name = "lblPrestamos";
             this.lblPrestamos.Size = new System.Drawing.Size(112, 13);
             this.lblPrestamos.TabIndex = 7;
             this.lblPrestamos.Text = "Numero de Prestamo: ";
             // 
             // lblCuotas
             // 
             this.lblCuotas.AutoSize = true;
             this.lblCuotas.Location = new System.Drawing.Point(24, 176);
             this.lblCuotas.Name = "lblCuotas";
             this.lblCuotas.Size = new System.Drawing.Size(96, 13);
             this.lblCuotas.TabIndex = 8;
             this.lblCuotas.Text = "Cuotas Pendientes";
             // 
             // FrmAltaPago
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(719, 451);
             this.Controls.Add(this.lblCuotas);
             this.Controls.Add(this.lblPrestamos);
             this.Controls.Add(this.lblClientes);
             this.Controls.Add(this.lblFecha);
             this.Controls.Add(this.btnGuardarPago);
             this.Controls.Add(this.dgvCuotas);
             this.Controls.Add(this.cmbPrestamos);
             this.Controls.Add(this.cmbClientes);
             this.Controls.Add(this.dtpFechaPago);
             this.Name = "FrmAltaPago";
             this.Text = "FrmAltaPago";
             this.Load += new System.EventHandler(this.FrmAltaPago_Load);
             ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();

         }

         #endregion

         private System.Windows.Forms.DateTimePicker dtpFechaPago;
         private System.Windows.Forms.ComboBox cmbClientes;
         private System.Windows.Forms.ComboBox cmbPrestamos;
         private System.Windows.Forms.DataGridView dgvCuotas;
         private System.Windows.Forms.Button btnGuardarPago;
         private System.Windows.Forms.Label lblFecha;
         private System.Windows.Forms.Label lblClientes;
         private System.Windows.Forms.Label lblPrestamos;
         private System.Windows.Forms.Label lblCuotas;
     }
 }