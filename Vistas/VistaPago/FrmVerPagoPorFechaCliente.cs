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
    public partial class FrmVerPagoPorFechaCliente : Form
    {
        public FrmVerPagoPorFechaCliente()
        {
            InitializeComponent();
        }

         private void FrmVerPagoPorFechaCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
            lblCantidadPagos.Text = "Cantidad de pagos: 0";
            lblTotalPagado.Text = "Total pagado: $0.00";
        }

        private void cargarClientes()
        {
            DataTable dtClientes = ABMCliente.getClientes();
            dtClientes.Columns.Add("ApellidoNombre", typeof(string));

            foreach (DataRow row in dtClientes.Rows)
            {
                row["ApellidoNombre"] = row["Apellido"] + ", " + row["Nombre"];
            }

            cmbClientes.DataSource = dtClientes;
            cmbClientes.DisplayMember = "ApellidoNombre";
            cmbClientes.ValueMember = "DNI";
        }

        private void txtCliTitle_Click(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = cmbClientes.SelectedValue.ToString();
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Debe ingrese una busqueda de fechas correcta.");
                return;
            }

            DataSet ds = ABMPago.listar_pagos_por_fecha_y_cliente(dni, fechaDesde, fechaHasta);

            dgvPagos.DataSource = ds.Tables[0]; 

            if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
            {
                int cantidadPagos = Convert.ToInt32(ds.Tables[1].Rows[0]["CantidadPagos"]);
                decimal totalPagado = Convert.ToDecimal(ds.Tables[1].Rows[0]["TotalPagado"]);

                lblCantidadPagos.Text = string.Format("Cantidad de pagos: {0}", cantidadPagos);
                lblTotalPagado.Text = string.Format("Total pagado: ${0:F2}", totalPagado);
            }
            else
            {
                lblCantidadPagos.Text = "Cantidad de pagos: 0";
                lblTotalPagado.Text = "Total pagado: $0.00";
            }


        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
