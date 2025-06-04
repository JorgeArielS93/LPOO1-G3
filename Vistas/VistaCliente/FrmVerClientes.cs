using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas.VistaCliente
{
    public partial class FrmVerClientes : Form
    {
        public FrmVerClientes()
        {
            InitializeComponent();
        }

        private void FrmVerClientes_Load(object sender, EventArgs e)
        {
            numIngreso.Minimum = 0;
            numIngreso.Maximum = 1000000;
            comboBoxSexo.Items.Clear();
            comboBoxSexo.Items.Add("Masculino");
            comboBoxSexo.Items.Add("Femenino");
            comboBoxSexo.Items.Add("Otro");
            load_clientes();
        }

        private void load_clientes() 
        {
            dgvClientes.DataSource = ABMCliente.getClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null) 
            {
                txtDNI.Text = dgvClientes.CurrentRow.Cells["CLI_DNI"].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells["CLI_Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["CLI_Apellido"].Value.ToString();
                comboBoxSexo.Text = dgvClientes.CurrentRow.Cells["CLI_Sexo"].Value.ToString();
                fechaNacimiento.Value = Convert.ToDateTime(dgvClientes.CurrentRow.Cells["CLI_fechaNacimiento"].Value.ToString());
                numIngreso.Value = Convert.ToDecimal(dgvClientes.CurrentRow.Cells["CLI_Ingresos"].Value);
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["CLI_Direccion"].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells["CLI_Telefono"].Value.ToString();
            }
        }

        private void comboBoxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFNombre.Text != "" && txtFApellido.Text != "")
            {
                dgvClientes.DataSource = ABMCliente.filtrarClientes(txtFNombre.Text, txtFApellido.Text);
            }
            else
            {
                load_clientes();
            }
        }

        private void txtFNombre_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtFNombre_Enter(object sender, EventArgs e)
        {
            if (txtFNombre.Text == "NOMBRE")
            {
                txtFNombre.Text = "";
                txtFNombre.ForeColor = Color.Black;
            }
        }

        private void txtFApellido_Enter(object sender, EventArgs e)
        {
            if (txtFApellido.Text == "APELLIDO")
            {
                txtFApellido.Text = "";
                txtFApellido.ForeColor = Color.Black;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
               string.IsNullOrEmpty(txtApellido.Text) ||
               string.IsNullOrEmpty(txtDNI.Text) ||
               string.IsNullOrEmpty(comboBoxSexo.Text) ||
               string.IsNullOrEmpty(fechaNacimiento.Text) ||
               numIngreso.Value <= 0 ||
               string.IsNullOrEmpty(txtDireccion.Text) ||
               string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este cliente?",
                                               "Confirmar Modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Cliente cli = new Cliente
            {
                cli_DNI = txtDNI.Text.Trim(),
                cli_Nombre = txtNombre.Text.Trim(),
                cli_Apellido = txtApellido.Text.Trim(),
                cli_Sexo = comboBoxSexo.SelectedItem.ToString(),
                cli_FechaNacimiento = fechaNacimiento.Value,
                cli_Ingresos = numIngreso.Value,
                cli_Direccion = txtDireccion.Text.Trim(),
                cli_Telefono = txtTelefono.Text.Trim()
            };

            ABMCliente.modificarCliente(cli);

            MessageBox.Show("Cliente modificado correctamente.", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            load_clientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = dgvClientes.CurrentRow.Cells["CLI_DNI"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                ABMCliente.eliminarCliente(dni);

                MessageBox.Show("Cliente eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                load_clientes();
            }
        }

    }
}
