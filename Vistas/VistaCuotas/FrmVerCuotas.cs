using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas.VistaCuotas
{
    public partial class FrmVerCuotas : Form
    {
        public FrmVerCuotas()
        {
            InitializeComponent();
        }
        
        private void cargarClientes()
        {
            DataTable dt = ABMPrestamo.CargarClientes();
            cbCliente.DisplayMember = "NombreCompleto";
            cbCliente.ValueMember = "CLI_DNI";
            cbCliente.DataSource = dt;
            cbCliente.SelectedIndex = -1;
        }

        private string FormatearDNI(string dni)
        {
            if (dni.Length == 8)
            {
                return dni.Substring(0, 2) + "." + dni.Substring(2, 3) + "." + dni.Substring(5, 3);
            }
            else if (dni.Length == 7)
            {
                return dni.Substring(0, 1) + "." + dni.Substring(1, 3) + "." + dni.Substring(4, 3);
            }
            else
            {
                return dni;
            }
        }

        private void FrmVerCuotas_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void cbNPrestamo_SelectedValueChanged(object sender, EventArgs e)
        {
            int numero = int.Parse(cbNPrestamo.Text);
            DataTable dt = ABMPrestamo.listar_cuotas_por_numero_prestamo(numero);

            dgvCuotas.DataSource = dt;
            cargarEstadisticas(numero);
        }

        private void cbNPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex != -1 && cbCliente.SelectedValue != null)
            {
                string dni = cbCliente.SelectedValue.ToString();

                if (!string.IsNullOrEmpty(dni) && dni != "System.Data.DataRowView")
                {
                    lblDNI.Text = FormatearDNI(dni);

                    List<int> prestamos = ABMPrestamo.listarNroPrestamosPorDNICliente(dni);

                    cbNPrestamo.Items.Clear();

                    foreach (int nro in prestamos)
                    {
                        cbNPrestamo.Items.Add(nro);
                    }

                    if (prestamos.Count == 0)
                    {
                        MessageBox.Show("El cliente no posee préstamos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cbNPrestamo.SelectedIndex = -1;
                    }
                }
                else
                {
                    lblDNI.Text = "Seleccione un cliente";
                    cbNPrestamo.Items.Clear();
                }
            }
            else
            {
                lblDNI.Text = "Seleccione un cliente";
                cbNPrestamo.Items.Clear();
            }
        }


        private void cargarEstadisticas(int nroPrestamo)
        {
            DataTable dt = ABMPrestamo.ObtenerResumenCuotasPorClienteYPrestamo(nroPrestamo);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblPagadas.Text = "Cuotas Pagadas: " + row["CantidadCuotasPagadas"].ToString();
                lblPendientes.Text = "Cuotas Pendientes: " + row["CantidadCuotasPendientes"].ToString();

                decimal importePagado = 0;
                decimal importePendiente = 0;

                decimal.TryParse(row["ImporteTotalPagado"].ToString(), out importePagado);
                decimal.TryParse(row["ImporteTotalPendiente"].ToString(), out importePendiente);

                lblImportePagado.Text = "Importe Pagado: $" + importePagado.ToString("N2");
                lblImportePendiente.Text = "Importe Pendiente: $" + importePendiente.ToString("N2");

            }
            else
            {
                lblPagadas.Text = "Cuotas Pagadas: 0";
                lblPendientes.Text = "Cuotas Pendientes: 0";
                lblImportePagado.Text = "Importe Pagado: 0";
                lblImportePendiente.Text = "Importe Pendiente: 0";
            }
        }
    }
}
