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

            DataTable pagos = ABMPago.listar_pago_por_cliente(dni);

            dgvPagos.DataSource = pagos;
            int cantidad = pagos.Rows.Count;
            decimal total = 0;

            foreach (DataRow row in pagos.Rows)
            {
                if (row["importe"] != DBNull.Value)
                    total += Convert.ToDecimal(row["importe"]);
            }

            lblCantidadPagos.Text = "Pagos realizados: " + cantidad;
            lblTotalImporte.Text = "Importe total: $" + total.ToString("N2");
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
