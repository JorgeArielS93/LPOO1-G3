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
            dtpFechaPago.Value = DateTime.Now;

            isLoadingForm = true;
            cargarClientes();

            isLoadingForm = false;
        }

        private void cargarClientes()
        {
            DataTable dtClientes = ClasesBase.ABMPago.getTodosLosClientes();

            cmbClientes.DataSource = dtClientes;
            cmbClientes.DisplayMember = "CLI_Apellido"; 
            cmbClientes.ValueMember = "CLI_DNI"; 
            cmbClientes.SelectedIndex = -1; 
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
                cmbPrestamos.DataSource = null;
            }
        }

        private void cargarPrestamosPendientes(string dniCliente)
        {
            DataTable dtPrestamos = ClasesBase.ABMPago.getPrestamosPendientesPorCliente(dniCliente);

            if (dtPrestamos.Rows.Count > 0)
            {
                cmbPrestamos.DataSource = dtPrestamos;
                cmbPrestamos.DisplayMember = "PRE_Numero"; 
                cmbPrestamos.ValueMember = "PRE_Numero";   
                cmbPrestamos.SelectedIndex = -1;
            }
            else
            {
                cmbPrestamos.DataSource = null; 
                if (!isLoadingForm)
                {
                    MessageBox.Show("El cliente seleccionado no posee préstamos pendientes.", "Sin préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrestamos.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbPrestamos.SelectedItem;

                int numeroPrestamo = Convert.ToInt32(drv["PRE_Numero"]);

                cargarCuotasPendientes(numeroPrestamo);
            }
            else
            {
                dgvCuotas.DataSource = null; 
            }
        }

        private void cargarCuotasPendientes(int preNumero)
        {
            DataTable dtCuotas = ClasesBase.ABMPago.getCuotasPendientesPorPrestamo(preNumero);

            if (dtCuotas.Rows.Count > 0)
            {
                dgvCuotas.DataSource = dtCuotas;
            }
            else
            {
                dgvCuotas.DataSource = null;
                MessageBox.Show("El préstamo seleccionado no tiene cuotas pendientes.", "Sin Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {

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
            int cuoNumero = Convert.ToInt32(filaSeleccionada.Cells["CUO_Numero"].Value);
            decimal cuoImporte = Convert.ToDecimal(filaSeleccionada.Cells["CUO_Importe"].Value); 

            DateTime fechaPago = dtpFechaPago.Value;

            List<int> numerosDeCuotas = new List<int>();
            foreach (DataGridViewRow fila in dgvCuotas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    int numero = Convert.ToInt32(fila.Cells["CUO_Numero"].Value);
                    numerosDeCuotas.Add(numero);
                }
            }

            int menorNumeroCuota = numerosDeCuotas.Min();

            if (cuoNumero != menorNumeroCuota)
            {
                MessageBox.Show("No puede pagar esta cuota aún. Debe pagar las cuotas anteriores pendientes primero.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                ClasesBase.ABMPago.registrarPago(cuoCodigo, fechaPago, cuoImporte);

                MessageBox.Show("Pago registrado con éxito.", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                int preNumeroActual = Convert.ToInt32(cmbPrestamos.SelectedValue);
                cargarCuotasPendientes(preNumeroActual); 

                string dniClienteActual = cmbClientes.SelectedValue.ToString();
                cargarPrestamosPendientes(dniClienteActual); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}