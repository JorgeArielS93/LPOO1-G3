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
            cargarComboDestinos();
        }

        private void cargarComboDestinos()
        {
            cmbDestiny.DataSource = ABMDestino.getDestinos();
            cmbDestiny.DisplayMember = "Descripcion";
            cmbDestiny.ValueMember = "Codigo";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resetForm()
        {
            cmbDestiny.SelectedIndex = -1;
            dtpFechaDesde.Checked = false;
            dtpFechaHasta.Checked = false;
            cargarPrestamos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           object destinoRaw = cmbDestiny.SelectedValue;
           DateTime fechaDesde = dtpFechaDesde.Value;
           DateTime fechaHasta = dtpFechaHasta.Value;
           bool destinoValido = destinoRaw != null;
           bool fechasValidas = dtpFechaDesde.Checked && dtpFechaHasta.Checked;
           bool rangoFechasCorrecto = !fechasValidas || (fechaDesde < fechaHasta);
           if ((destinoValido || fechasValidas) && rangoFechasCorrecto)
           {
             dgvPrestamos.DataSource = ABMPrestamo.filtrarPrestamos(
             destinoValido ? (int)cmbDestiny.SelectedValue : -1,
             fechasValidas ? fechaDesde : DateTime.MinValue,
             fechasValidas ? fechaHasta : DateTime.MaxValue
             );
           }
           else
          {
          if (!destinoValido && !fechasValidas)
          {
              MessageBox.Show("Debe seleccionar al menos un destino o completar ambas fechas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              resetForm();
          }
          else if (fechasValidas && fechaDesde >= fechaHasta)
          {
            MessageBox.Show("La fecha desde debe ser menor que la fecha hasta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            resetForm();
          }
         }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
