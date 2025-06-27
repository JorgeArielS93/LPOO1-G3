using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas.VistaPago
{
    public partial class FrmVerPagoPorCliente : Form
    {
        public FrmVerPagoPorCliente()
        {
            InitializeComponent();
        }

        private void FrmVerPagoPorCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarPagos();
        }

        private void cargarClientes()
        {
            DataTable dtClientes = ABMCliente.getClientes();
            dtClientes.Columns.Add("ApellidoNombre", typeof(string));

            foreach (DataRow row in dtClientes.Rows)
            {
                row["ApellidoNombre"] = row["Apellido"] + ", " + row["Nombre"];
            }

            cmbCliente.DataSource = dtClientes;
            cmbCliente.DisplayMember = "ApellidoNombre";
            cmbCliente.ValueMember = "DNI";
        }

        private void cargarPagos()
        {

            DataTable dt = ABMPago.getPagos();

            dgvPagos.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string dni = cmbCliente.SelectedValue.ToString();

            dgvPagos.DataSource = ABMPago.listar_pago_por_cliente(dni);
        }
    }
}
