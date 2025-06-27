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
    public partial class FrmVerPrestamoPorDestino : Form
    {
        public FrmVerPrestamoPorDestino()
        {
            InitializeComponent();
        }

        private void FrmVerPrestamoPorDestino_Load(object sender, EventArgs e)
        {
            cargarDestinos();
            cargarPrestamos();
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string destino = cmbDestino.SelectedValue.ToString();
            
            dgvPrestamos.DataSource = ABMPrestamo.listar_prestamos_por_destino(destino);

        }
    }
}
