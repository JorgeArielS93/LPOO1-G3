using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAltaCliente : Form
    {
        public static List<Cliente> listaClientes = new List<Cliente>();

        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!validarCliente())
            {
                return;
            }
            Cliente cliente = new Cliente();
            cliente.cli_DNI = txtDNI.Text;
            cliente.cli_Nombre = txtNombre.Text;
            cliente.cli_Apellido = txtApellido.Text;
            cliente.cli_Sexo = comboBoxSexo.SelectedItem.ToString();
            cliente.cli_FechaNacimiento = fechaNacimiento.Value;
            cliente.cli_Ingresos = numIngreso.Value;
            cliente.cli_Direccion = txtDireccion.Text;
            cliente.cli_Telefono = txtTelefono.Text;

            ABMCliente.altaCliente(cliente);
            MessageBox.Show("Cliente agregado!");

            this.Close();
        }

        private bool validarCliente()
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El campo DNI es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            long dniTemp;
            if (!long.TryParse(txtDNI.Text, out dniTemp))
            {
                MessageBox.Show("El DNI debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxSexo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un sexo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (fechaNacimiento.Value >= DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento debe ser anterior a hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo Dirección es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el DNI no esté ya en uso
            if (ABMCliente.existeDNI(txtDNI.Text))
            {
                MessageBox.Show("El DNI ingresado ya está registrado en otro cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSexo.Items.Add("Masculino");
            comboBoxSexo.Items.Add("Femenino");
            comboBoxSexo.Items.Add("Otro");
        }

        private void fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

        }

    }
}
