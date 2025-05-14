namespace Vistas
{
    partial class FrmPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.obtenerCliente = new System.Windows.Forms.ComboBox();
            this.fechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.importePrest = new System.Windows.Forms.NumericUpDown();
            this.tasaInteres = new System.Windows.Forms.NumericUpDown();
            this.cantCuotas = new System.Windows.Forms.NumericUpDown();
            this.estados = new System.Windows.Forms.ComboBox();
            this.btnSolicitarPrestamo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.txtDestinoAsignado = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.importePrest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasaInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tasa Interes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad de Cuotas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado";
            // 
            // obtenerCliente
            // 
            this.obtenerCliente.FormattingEnabled = true;
            this.obtenerCliente.Location = new System.Drawing.Point(236, 54);
            this.obtenerCliente.Name = "obtenerCliente";
            this.obtenerCliente.Size = new System.Drawing.Size(186, 24);
            this.obtenerCliente.TabIndex = 0;
            this.obtenerCliente.SelectedIndexChanged += new System.EventHandler(this.obtenerCliente_SelectedIndexChanged);
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.Location = new System.Drawing.Point(236, 180);
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.Size = new System.Drawing.Size(186, 22);
            this.fechaPrestamo.TabIndex = 1;
            // 
            // importePrest
            // 
            this.importePrest.DecimalPlaces = 2;
            this.importePrest.Location = new System.Drawing.Point(236, 221);
            this.importePrest.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.importePrest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.importePrest.Name = "importePrest";
            this.importePrest.Size = new System.Drawing.Size(186, 22);
            this.importePrest.TabIndex = 2;
            this.importePrest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tasaInteres
            // 
            this.tasaInteres.DecimalPlaces = 2;
            this.tasaInteres.Location = new System.Drawing.Point(236, 262);
            this.tasaInteres.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tasaInteres.Name = "tasaInteres";
            this.tasaInteres.Size = new System.Drawing.Size(186, 22);
            this.tasaInteres.TabIndex = 3;
            // 
            // cantCuotas
            // 
            this.cantCuotas.Location = new System.Drawing.Point(236, 303);
            this.cantCuotas.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.cantCuotas.Name = "cantCuotas";
            this.cantCuotas.Size = new System.Drawing.Size(186, 22);
            this.cantCuotas.TabIndex = 4;
            // 
            // estados
            // 
            this.estados.AutoCompleteCustomSource.AddRange(new string[] {
            "Aprobado",
            "Cancelado",
            "Otro"});
            this.estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estados.FormattingEnabled = true;
            this.estados.Items.AddRange(new object[] {
            "Aprobado",
            "Cancelado",
            "Otro"});
            this.estados.Location = new System.Drawing.Point(236, 344);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(186, 24);
            this.estados.TabIndex = 5;
            this.estados.SelectedIndexChanged += new System.EventHandler(this.estados_SelectedIndexChanged);
            // 
            // btnSolicitarPrestamo
            // 
            this.btnSolicitarPrestamo.Location = new System.Drawing.Point(321, 451);
            this.btnSolicitarPrestamo.Name = "btnSolicitarPrestamo";
            this.btnSolicitarPrestamo.Size = new System.Drawing.Size(157, 45);
            this.btnSolicitarPrestamo.TabIndex = 6;
            this.btnSolicitarPrestamo.Text = "Solicitar Prestamo";
            this.btnSolicitarPrestamo.UseVisualStyleBackColor = true;
            this.btnSolicitarPrestamo.Click += new System.EventHandler(this.btnSolicitarPrestamo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(39, 451);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 45);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(461, 92);
            this.btnDestino.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(186, 28);
            this.btnDestino.TabIndex = 8;
            this.btnDestino.Text = "Asignar destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Location = new System.Drawing.Point(461, 133);
            this.btnPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(186, 28);
            this.btnPeriodo.TabIndex = 9;
            this.btnPeriodo.Text = "Asignar periodo";
            this.btnPeriodo.UseVisualStyleBackColor = true;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // txtDestinoAsignado
            // 
            this.txtDestinoAsignado.Location = new System.Drawing.Point(236, 95);
            this.txtDestinoAsignado.Name = "txtDestinoAsignado";
            this.txtDestinoAsignado.ReadOnly = true;
            this.txtDestinoAsignado.Size = new System.Drawing.Size(186, 22);
            this.txtDestinoAsignado.TabIndex = 10;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(236, 139);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(186, 22);
            this.txtPeriodo.TabIndex = 11;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 524);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtDestinoAsignado);
            this.Controls.Add(this.btnPeriodo);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSolicitarPrestamo);
            this.Controls.Add(this.estados);
            this.Controls.Add(this.cantCuotas);
            this.Controls.Add(this.tasaInteres);
            this.Controls.Add(this.importePrest);
            this.Controls.Add(this.fechaPrestamo);
            this.Controls.Add(this.obtenerCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importePrest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasaInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox obtenerCliente;
        private System.Windows.Forms.DateTimePicker fechaPrestamo;
        private System.Windows.Forms.NumericUpDown importePrest;
        private System.Windows.Forms.NumericUpDown tasaInteres;
        private System.Windows.Forms.NumericUpDown cantCuotas;
        private System.Windows.Forms.ComboBox estados;
        private System.Windows.Forms.Button btnSolicitarPrestamo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.TextBox txtDestinoAsignado;
        private System.Windows.Forms.TextBox txtPeriodo;
    }
}