using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

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

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Debe ingrese una busqueda de fechas correcta.");
            }

            dgvPrestamosFecha.DataSource = ABMPrestamo.exec_listar_prestamos_por_fecha_sp(fechaDesde, fechaHasta);

        }

        private void FrmVerPrestamosPorFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
