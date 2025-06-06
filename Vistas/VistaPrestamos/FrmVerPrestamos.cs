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
    public partial class FrmVerPrestamos : Form
    {
        public FrmVerPrestamos()
        {
            InitializeComponent();
        }


        private void FrmVerPrestamos_Load(object sender, EventArgs e)
        {
            cargarPrestamos();
        }

        private void cargarPrestamos()
        {
            DataTable dt = ABMPrestamo.getPrestamos();

            dgvPrestamos.DataSource = dt;
        }

        private void dgvPrestamos_CurrentCellChanged(object sender, EventArgs e)
        {   
            if(dgvPrestamos.CurrentRow != null){

                Destino destino = ABMDestino.getDestinoByCodigo(Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["DES_Codigo"].Value.ToString()));
                Periodo periodo = ABMPrestamo.getPeriodoByCodigo(Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["PER_Codigo"].Value.ToString()));
                Cliente cliente = ABMCliente.getClienteByDNI(dgvPrestamos.CurrentRow.Cells["CLI_DNI"].Value.ToString());

                lblDestino.Text = "Destino: " + destino.des_Descripcion;
                lblPeriodo.Text = "Periodo: " + periodo.per_Descripcion;
                lblCliente.Text = "Cliente: " + cliente.cli_Apellido + ", " + cliente.cli_Nombre;
                DataTable dt = ABMPrestamo.getCuotas(Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["PRE_Numero"].Value.ToString()));
                dgbCuotas.DataSource = dt;
            }
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
