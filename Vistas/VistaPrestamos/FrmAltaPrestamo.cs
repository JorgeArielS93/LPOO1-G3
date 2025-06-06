using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data;

namespace Vistas.VistaPrestamos
{
    public partial class FrmAltaPrestamo : Form
    {
        public FrmAltaPrestamo()
        {
            InitializeComponent();
        }

        public void FrmAltaPrestamo_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarDestinos();
            CargarPeriodos();
        }

        public void CargarClientes()
        {
            DataTable dt = ABMPrestamo.CargarClientes();
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "CLI_DNI";
            cmbCliente.DataSource = dt;
            cmbCliente.SelectedIndex = -1;
        }

        public void CargarDestinos()
        {
                cmbDestino.DataSource = ABMPrestamo.CargarDestinos();
                cmbDestino.DisplayMember = "DES_Descripcion";
                cmbDestino.ValueMember = "DES_Codigo";
                cmbDestino.SelectedIndex = -1;
            
        }

        public void CargarPeriodos()
        {
                cmbPeriodo.DataSource = ABMPrestamo.CargarPeriodos();
                cmbPeriodo.DisplayMember = "PER_Descripcion";
                cmbPeriodo.ValueMember = "PER_Codigo";
                cmbPeriodo.SelectedIndex = -1;
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return; 
            }

            string cliDni = cmbCliente.SelectedValue.ToString();
            int desCodigo = (int)cmbDestino.SelectedValue;
            int perCodigo = (int)cmbPeriodo.SelectedValue;
            DateTime preFecha = DateTime.Now;
            decimal preImporte = decimal.Parse(txtImporte.Text);
            float preTasaInteres = float.Parse(txtTasaInteres.Text);
            int preCantidadCuotas = int.Parse(txtCantidadCuotas.Text);

            try
            {
                int prestamoNumero = ABMPrestamo.InsertarPrestamoYCuotas(
                    cliDni, desCodigo, perCodigo, preFecha,
                    preImporte, preTasaInteres, preCantidadCuotas);

                MessageBox.Show("Préstamo (ID: " + prestamoNumero + ") y cuotas registrados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para Importe, Tasa de Interés y Cantidad de Cuotas.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarCampos()
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbDestino.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un Destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPeriodo.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un Período de Pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal importe;
            if (!decimal.TryParse(txtImporte.Text, out importe) || importe <= 0)
            {
                MessageBox.Show("Ingrese un Importe válido (número positivo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            float tasaInteres;
            if (!float.TryParse(txtTasaInteres.Text, out tasaInteres) || tasaInteres < 0)
            {
                MessageBox.Show("Ingrese una Tasa de Interés válida (número no negativo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int cantidadCuotas;
            if (!int.TryParse(txtCantidadCuotas.Text, out cantidadCuotas) || cantidadCuotas <= 0)
            {
                MessageBox.Show("Ingrese una Cantidad de Cuotas válida (número entero positivo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

    }
}
