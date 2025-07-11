using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using ClasesBase.Entidades;

namespace Vistas.VistaPrestamos
{
    public partial class FrmVerPrestamoPorDestino : Form
    {
        public FrmVerPrestamoPorDestino()
        {
            InitializeComponent();
        }

        private void FrmVerPrestamoPorDestino_Load(object sender, EventArgs e)
        {
            cargarDestinos();
            if (cmbDestino.SelectedValue != null)
            {
                string destinoInicial = cmbDestino.SelectedValue.ToString();
                dgvPrestamos.DataSource = ABMPrestamo.listar_prestamos_por_destino(destinoInicial);
                ActualizarEstadisticas(destinoInicial); 
            }
            else
            {
               
                lblOtorgados.Text = "Otorgados: 0";
                lblPendientes.Text = "Pendientes: 0";
                lblCancelados.Text = "Cancelados: 0";
                lblAnulados.Text = "Anulados: 0";
                lblTotalPrestamos.Text = "Total Préstamos: 0";
            }
        }

        private void cargarDestinos()
        {
            cmbDestino.DataSource = ABMDestino.getDestinos();
            cmbDestino.DisplayMember = "Descripcion";
            cmbDestino.ValueMember = "Descripcion";
        }

        private void cargarPrestamos()
        {
            DataTable dt = ABMPrestamo.getPrestamosVista();
            dgvPrestamos.DataSource = dt;
        }

        private void ActualizarEstadisticas(string destino)
        {
            PrestamoEstadisticas stats = ABMPrestamo.obtenerCantPrestamosPorDestino(destino);

            lblOtorgados.Text = "Otorgados: " + stats.CantidadOtorgados.ToString();
            lblPendientes.Text = "Pendientes: " + stats.CantidadPendientes.ToString();
            lblCancelados.Text = "Cancelados: " + stats.CantidadCancelados.ToString();
            lblAnulados.Text = "Anulados: " + stats.CantidadAnulados.ToString();
            lblTotalPrestamos.Text = "Total Préstamos: " + stats.CantidadTotalPrestamos.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string destino = cmbDestino.SelectedValue.ToString();

            dgvPrestamos.DataSource = ABMPrestamo.listar_prestamos_por_destino(destino);
            ActualizarEstadisticas(destino); 
        }

        
        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestino.SelectedValue != null)
            {
                string destino = cmbDestino.SelectedValue.ToString();
                dgvPrestamos.DataSource = ABMPrestamo.listar_prestamos_por_destino(destino);
                ActualizarEstadisticas(destino); 
            }
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbDestino_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
