﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas.VistaPago
{
    public partial class FrmAltaPago : Form
    {
        private bool isLoadingForm = true;
        public FrmAltaPago()
        {
            InitializeComponent();
        }

        private void FrmAltaPago_Load(object sender, EventArgs e)
        {
            // Configurar el DateTimePicker para la fecha actual (punto a)
            dtpFechaPago.Value = DateTime.Now;

            // Antes de cargar los clientes, establece la bandera en true
            isLoadingForm = true;
            // Cargar clientes en el ComboBox (punto b)
            cargarClientes();

            isLoadingForm = false;
        }

        private void cargarClientes()
        {
            DataTable dtClientes = ClasesBase.ABMPago.getTodosLosClientes();

            cmbClientes.DataSource = dtClientes;
            cmbClientes.DisplayMember = "CLI_Apellido"; // O "CLI_Nombre" + " " + "CLI_Apellido"
            cmbClientes.ValueMember = "CLI_DNI"; // El valor asociado es el DNI
            cmbClientes.SelectedIndex = -1; // No seleccionar ninguno por defecto
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                string dniCliente = cmbClientes.SelectedValue.ToString();
                cargarPrestamosPendientes(dniCliente);
            }
            else
            {
                // Limpiar el ComboBox de préstamos si no hay cliente seleccionado
                cmbPrestamos.DataSource = null;
                // MessageBox.Show("Seleccione un cliente para ver sus préstamos.");
            }
        }

        private void cargarPrestamosPendientes(string dniCliente)
        {
            DataTable dtPrestamos = ClasesBase.ABMPago.getPrestamosPendientesPorCliente(dniCliente);

            if (dtPrestamos.Rows.Count > 0)
            {
                cmbPrestamos.DataSource = dtPrestamos;
                cmbPrestamos.DisplayMember = "PRE_Numero"; // Mostrar el número de préstamo
                cmbPrestamos.ValueMember = "PRE_Numero";   // El valor asociado es el número de préstamo
                cmbPrestamos.SelectedIndex = -1;
            }
            else
            {
                cmbPrestamos.DataSource = null; // Limpiar el ComboBox de préstamos
                if (!isLoadingForm)
                {
                    MessageBox.Show("El cliente seleccionado no posee préstamos pendientes.", "Sin préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CAMBIO AQUÍ: Accede a SelectedItem y luego al DataRowView
            if (cmbPrestamos.SelectedItem != null)
            {
                // Convierte el SelectedItem a DataRowView
                DataRowView drv = (DataRowView)cmbPrestamos.SelectedItem;

                int numeroPrestamo = Convert.ToInt32(drv["PRE_Numero"]);

                cargarCuotasPendientes(numeroPrestamo);
            }
            else
            {
                dgvCuotas.DataSource = null; // Limpiar la grilla si no hay préstamo seleccionado
            }
        }

        private void cargarCuotasPendientes(int preNumero)
        {
            DataTable dtCuotas = ClasesBase.ABMPago.getCuotasPendientesPorPrestamo(preNumero);

            if (dtCuotas.Rows.Count > 0)
            {
                dgvCuotas.DataSource = dtCuotas;
                // Opcional: Configurar columnas de la grilla para mejor visualización
            }
            else
            {
                dgvCuotas.DataSource = null;
                MessageBox.Show("El préstamo seleccionado no tiene cuotas pendientes.", "Sin Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            // Validaciones básicas antes de guardar
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPrestamos.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un préstamo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCuotas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una cuota a pagar en la grilla.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow filaSeleccionada = dgvCuotas.SelectedRows[0];
            int cuoCodigo = Convert.ToInt32(filaSeleccionada.Cells["CUO_Codigo"].Value);
            decimal cuoImporte = Convert.ToDecimal(filaSeleccionada.Cells["CUO_Importe"].Value); // Asegúrate de que el nombre de la columna es correcto

            DateTime fechaPago = dtpFechaPago.Value; // Obtener la fecha del DateTimePicker

            try
            {
                ClasesBase.ABMPago.registrarPago(cuoCodigo, fechaPago, cuoImporte);

                MessageBox.Show("Pago registrado con éxito.", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                int preNumeroActual = Convert.ToInt32(cmbPrestamos.SelectedValue);
                cargarCuotasPendientes(preNumeroActual); // Recarga la grilla

                string dniClienteActual = cmbClientes.SelectedValue.ToString();
                cargarPrestamosPendientes(dniClienteActual); // Recarga los préstamos del cliente

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}