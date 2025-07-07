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
    public partial class FrmAnularPrestamo : Form
    {
        public FrmAnularPrestamo()
        {
            InitializeComponent();
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroPrestamo.Text))
            {
                MessageBox.Show("Por favor, ingrese el número de préstamo a anular.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroPrestamo;
            if (!int.TryParse(txtNumeroPrestamo.Text, out numeroPrestamo))
            {
                MessageBox.Show("El número de préstamo debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreCliente = "Desconocido";
            decimal importePrestamo = 0;

            try
            {
                DataRow prestamoDetails = ABMPrestamo.obtenerDetallePrestamo(numeroPrestamo);

                if (prestamoDetails != null)
                {
                    nombreCliente = prestamoDetails["NombreCompletoCliente"].ToString();
                    importePrestamo = Convert.ToDecimal(prestamoDetails["PRE_Importe"]);
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para el préstamo N° " + numeroPrestamo.ToString() + ". Verifique el número ingresado.", "Préstamo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string mensajeConfirmacion = "¿Está seguro que desea anular el préstamo N° " + numeroPrestamo.ToString() + "?\n" +
                                         "Cliente: " + nombreCliente + "\n" +
                                         "Importe: $" + importePrestamo.ToString("N2"); 

            DialogResult confirmacion = MessageBox.Show(
                mensajeConfirmacion,
                "Confirmar Anulación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    int resultado = ABMPrestamo.AnularPrestamo(numeroPrestamo);

                    switch (resultado)
                    {
                        case 0:
                            MessageBox.Show("Préstamo anulado con éxito.", "Anulación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case 1:
                            MessageBox.Show("El préstamo ya esta anulado. Verifique el número ingresado.", "Error de Anulación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("El préstamo no puede ser anulado porque tiene cuotas que ya han sido pagadas.", "Error de Anulación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        default:
                            MessageBox.Show("Ocurrió un error desconocido al anular el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar anular el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumeroPrestamo.Text, out numero))
            {
                dgvPrestamos.DataSource = ABMPrestamo.listar_prestamos_por_numero(numero);
                dgvCuotas.DataSource = ABMPrestamo.listar_cuotas_por_numero_prestamo(numero);
            }
            else
            {
                MessageBox.Show("Ingrese un número de préstamo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmAnularPrestamo_Load(object sender, EventArgs e)
        {

        }

    }
}
