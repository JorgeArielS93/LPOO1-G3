namespace Vistas.VistaCliente
{
    partial class FrmVerClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.txtFNombre = new System.Windows.Forms.TextBox();
            this.txtFApellido = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.numIngreso = new System.Windows.Forms.NumericUpDown();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(50, 86);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(518, 249);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvClientes.CurrentCellChanged += new System.EventHandler(this.dgvClientes_CurrentCellChanged);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(47, 42);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(34, 13);
            this.lblFiltros.TabIndex = 1;
            this.lblFiltros.Text = "Filtros";
            // 
            // txtFNombre
            // 
            this.txtFNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFNombre.Location = new System.Drawing.Point(87, 39);
            this.txtFNombre.Name = "txtFNombre";
            this.txtFNombre.Size = new System.Drawing.Size(143, 20);
            this.txtFNombre.TabIndex = 5;
            this.txtFNombre.Text = "NOMBRE";
            this.txtFNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtFNombre.Enter += new System.EventHandler(this.txtFNombre_Enter);
            this.txtFNombre.MouseEnter += new System.EventHandler(this.txtFNombre_MouseEnter);
            // 
            // txtFApellido
            // 
            this.txtFApellido.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFApellido.Location = new System.Drawing.Point(236, 39);
            this.txtFApellido.Name = "txtFApellido";
            this.txtFApellido.Size = new System.Drawing.Size(143, 20);
            this.txtFApellido.TabIndex = 6;
            this.txtFApellido.Text = "APELLIDO";
            this.txtFApellido.Enter += new System.EventHandler(this.txtFApellido_Enter);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(403, 36);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(607, 36);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(87, 13);
            this.lblDatos.TabIndex = 8;
            this.lblDatos.Text = "Datos del Cliente";
            // 
            // numIngreso
            // 
            this.numIngreso.DecimalPlaces = 2;
            this.numIngreso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numIngreso.Location = new System.Drawing.Point(748, 272);
            this.numIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.numIngreso.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            131072});
            this.numIngreso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numIngreso.Name = "numIngreso";
            this.numIngreso.Size = new System.Drawing.Size(140, 20);
            this.numIngreso.TabIndex = 23;
            this.numIngreso.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(748, 359);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(663, 359);
            this.Telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 30;
            this.Telefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(748, 315);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(140, 20);
            this.txtDireccion.TabIndex = 24;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(663, 315);
            this.Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 29;
            this.Direccion.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ingresos";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(748, 228);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(140, 20);
            this.fechaNacimiento.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha de Nac.";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.comboBoxSexo.Location = new System.Drawing.Point(748, 182);
            this.comboBoxSexo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSexo.TabIndex = 19;
            this.comboBoxSexo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSexo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sexo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(748, 138);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 20);
            this.txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(748, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(748, 51);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(140, 20);
            this.txtDNI.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(666, 58);
            this.DNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 16;
            this.DNI.Text = "DNI";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(813, 399);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(666, 399);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmVerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 441);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.numIngreso);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFApellido);
            this.Controls.Add(this.txtFNombre);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmVerClientes";
            this.Text = "FrmVerClientes";
            this.Load += new System.EventHandler(this.FrmVerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.TextBox txtFNombre;
        private System.Windows.Forms.TextBox txtFApellido;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.NumericUpDown numIngreso;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}