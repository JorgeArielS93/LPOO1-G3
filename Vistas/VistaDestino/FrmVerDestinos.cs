using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas.VistaDestino
{
    public partial class FrmVerDestinos : Form
    {
        public FrmVerDestinos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmVerDestinos_Load(object sender, EventArgs e)
        {
            cargarDestinos();
        }

        private void cargarDestinos()
        {
            dgvDestino.DataSource = ABMDestino.getDestinos();
        }

        private void dgvDestino_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDestino.CurrentRow != null)
            {
                txtFDescripcion.Text = dgvDestino.CurrentRow.Cells["DES_Descripcion"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFDescripcion.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este destino?",
                                              "Confirmar Modificación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            Destino des = new Destino
            {
                des_Codigo = Convert.ToInt32(dgvDestino.CurrentRow.Cells["DES_Codigo"].Value),
                des_Descripcion = txtFDescripcion.Text.Trim()
            };

            ABMDestino.modificarDestino(des);

            MessageBox.Show("Destino modificado correctamente.", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarDestinos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvDestino.CurrentRow.Cells["DES_Codigo"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este destino?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                ABMDestino.eliminarDestino(codigo);

                MessageBox.Show("Destino eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarDestinos();
            }
        }



    }
}
