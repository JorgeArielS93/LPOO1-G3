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
    public partial class FrmVerPrestamosPorFecha : Form
    {
        public FrmVerPrestamosPorFecha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Debe ingrese una busqueda de fechas correcta.");
                return;
            }

            dgvPrestamosFecha.DataSource = ABMPrestamo.exec_listar_prestamos_por_fecha_sp(fechaDesde, fechaHasta);
            ActualizarEstadisticas(fechaDesde,fechaHasta);

        }

        private void ActualizarEstadisticas(DateTime desde, DateTime hasta) {

            PrestamoEstadisticas stats = ABMPrestamo.obtenerCantPrestamosPorFecha(desde, hasta);

            lblOtorgados.Text = "Otorgados: " + stats.CantidadOtorgados.ToString();
            lblPendientes.Text = "Pendientes: " + stats.CantidadPendientes.ToString();
            lblCancelados.Text = "Cancelados: " + stats.CantidadCancelados.ToString();
            lblAnulados.Text = "Anulados: " + stats.CantidadAnulados.ToString();
            lblTotal.Text = "Total Préstamos: " + stats.CantidadTotalPrestamos.ToString();
        
        }

        private void FrmVerPrestamosPorFecha_Load(object sender, EventArgs e)
        {
            lblOtorgados.Text = "Otorgados: 0";
            lblPendientes.Text = "Pendientes: 0";
            lblCancelados.Text = "Cancelados: 0";
            lblAnulados.Text = "Anulados: 0";
            lblTotal.Text = "Total Préstamos: 0";
        }

        private void dgvPrestamosFecha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
