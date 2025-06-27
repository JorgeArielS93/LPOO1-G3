namespace Vistas
{
    partial class FrmPago
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.dtgPagoCliente = new System.Windows.Forms.DataGridView();
            this.CUO_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGImporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRE_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRE_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet = new Vistas.prestamosDataSet();
            this.pagoTableAdapter = new Vistas.prestamosDataSetTableAdapters.PagoTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Vistas.prestamosDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGOS REALIZADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(337, 78);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(187, 21);
            this.cmbClients.TabIndex = 2;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // dtgPagoCliente
            // 
            this.dtgPagoCliente.AutoGenerateColumns = false;
            this.dtgPagoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUO_Numero,
            this.pAGCodigoDataGridViewTextBoxColumn,
            this.pAGFechaDataGridViewTextBoxColumn,
            this.pAGImporteDataGridViewTextBoxColumn,
            this.CLI_Apellido,
            this.CLI_Nombre,
            this.PRE_Numero,
            this.PRE_Importe});
            this.dtgPagoCliente.DataSource = this.pagoBindingSource;
            this.dtgPagoCliente.Location = new System.Drawing.Point(12, 189);
            this.dtgPagoCliente.Name = "dtgPagoCliente";
            this.dtgPagoCliente.Size = new System.Drawing.Size(844, 150);
            this.dtgPagoCliente.TabIndex = 3;
            // 
            // CUO_Numero
            // 
            this.CUO_Numero.HeaderText = "CUO_Numero";
            this.CUO_Numero.Name = "CUO_Numero";
            // 
            // pAGCodigoDataGridViewTextBoxColumn
            // 
            this.pAGCodigoDataGridViewTextBoxColumn.DataPropertyName = "PAG_Codigo";
            this.pAGCodigoDataGridViewTextBoxColumn.HeaderText = "PAG_Codigo";
            this.pAGCodigoDataGridViewTextBoxColumn.Name = "pAGCodigoDataGridViewTextBoxColumn";
            this.pAGCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAGFechaDataGridViewTextBoxColumn
            // 
            this.pAGFechaDataGridViewTextBoxColumn.DataPropertyName = "PAG_Fecha";
            this.pAGFechaDataGridViewTextBoxColumn.HeaderText = "PAG_Fecha";
            this.pAGFechaDataGridViewTextBoxColumn.Name = "pAGFechaDataGridViewTextBoxColumn";
            // 
            // pAGImporteDataGridViewTextBoxColumn
            // 
            this.pAGImporteDataGridViewTextBoxColumn.DataPropertyName = "PAG_Importe";
            this.pAGImporteDataGridViewTextBoxColumn.HeaderText = "PAG_Importe";
            this.pAGImporteDataGridViewTextBoxColumn.Name = "pAGImporteDataGridViewTextBoxColumn";
            // 
            // CLI_Apellido
            // 
            this.CLI_Apellido.HeaderText = "CLI_Apellido";
            this.CLI_Apellido.Name = "CLI_Apellido";
            // 
            // CLI_Nombre
            // 
            this.CLI_Nombre.HeaderText = "CLI_Nombre";
            this.CLI_Nombre.Name = "CLI_Nombre";
            // 
            // PRE_Numero
            // 
            this.PRE_Numero.HeaderText = "PRE_Numero";
            this.PRE_Numero.Name = "PRE_Numero";
            // 
            // PRE_Importe
            // 
            this.PRE_Importe.HeaderText = "PRE_Importe";
            this.PRE_Importe.Name = "PRE_Importe";
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "Pago";
            this.pagoBindingSource.DataSource = this.prestamosDataSet;
            // 
            // prestamosDataSet
            // 
            this.prestamosDataSet.DataSetName = "prestamosDataSet";
            this.prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.prestamosDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 479);
            this.Controls.Add(this.dtgPagoCliente);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPago";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.DataGridView dtgPagoCliente;
        private prestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private prestamosDataSetTableAdapters.PagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private prestamosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUO_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGImporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE_Importe;
    }
}