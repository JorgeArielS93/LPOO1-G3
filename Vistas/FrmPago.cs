using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
            cargarComboClientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cargarComboClientes()
        {
            cmbClients.DataSource = ABMCliente.getClientes();
            cmbClients.DisplayMember = "NombreCompleto";
            cmbClients.ValueMember = "Dni";
            cmbClients.SelectedIndex = -1;

        } 

        private void FrmPago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prestamosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.prestamosDataSet.Cliente);
            // TODO: This line of code loads data into the 'prestamosDataSet.Pago' table. You can move, or remove it, as needed.
            this.pagoTableAdapter.Fill(this.prestamosDataSet.Pago);

        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClients.SelectedIndex == -1 || cmbClients.SelectedValue == null)
                return;
            string dniSeleccionado = cmbClients.SelectedValue.ToString();
            DataTable dataTable = ABMPrestamo.getPrestamos();
            dtgPagoCliente.DataSource = ABMCliente.getPagosDeClientes(dniSeleccionado);
        }
    }
}
