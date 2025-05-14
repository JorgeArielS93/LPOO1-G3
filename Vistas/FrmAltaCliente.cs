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
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return;
            }

            if (comboBoxSexo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un sexo.");
                return;
            }

            if (fechaNacimiento.Value == null || fechaNacimiento.Value == DateTime.MinValue)
            {
                MessageBox.Show("La fecha de nacimiento es obligatoria.");
                return;
            }

            if (numIngreso.Value == 0)
            {
                MessageBox.Show("Los ingresos son obligatorios.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.");
                return;
            }

            Cliente nuevoCliente = new Cliente
            {
                cli_DNI = txtDNI.Text,
                cli_Apellido = txtApellido.Text,
                cli_Nombre = txtNombre.Text,
                cli_Sexo = comboBoxSexo.SelectedItem.ToString(),
                cli_FechaNacimiento = fechaNacimiento.Value,
                cli_Ingresos = numIngreso.Value,
                cli_Direccion = txtDireccion.Text,
                cli_Telefono = txtTelefono.Text
            };

            listaClientes.Add(nuevoCliente);

            MessageBox.Show("Cliente Guardado, DNI: " + nuevoCliente.cli_DNI);

            this.Close();
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

    }
}
