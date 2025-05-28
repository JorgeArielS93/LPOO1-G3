using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using Vistas;

namespace Vistas
{
    public partial class FrmPrestamo : Form
    {
        public static List<Prestamo> listaPrestamos = new List<Prestamo>();

        private Destino destinoSeleccionado;
        private Periodo periodoSeleccionado;

        public FrmPrestamo()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmPrestamo_Load);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void obtenerCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            obtenerCliente.Items.Clear();

            foreach (Cliente c in FrmAltaCliente.listaClientes)
            {
                obtenerCliente.Items.Add(c.cli_DNI);
            }

            if (obtenerCliente.Items.Count > 0)
                obtenerCliente.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSolicitarPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo nuevoPrestamo = new Prestamo();

            nuevoPrestamo.cli_DNI = obtenerCliente.Text;
            //nuevoPrestamo.des_Codigo = 
            //nuevoPrestamo.per_Codigo = 
            nuevoPrestamo.pre_Fecha = fechaPrestamo.Value;
            nuevoPrestamo.pre_Importe = importePrest.Value;
            nuevoPrestamo.pre_TasaInteres = (Double)tasaInteres.Value;
            nuevoPrestamo.pre_CantidadCuotas = (int)cantCuotas.Value;
            nuevoPrestamo.pre_Estado = estados.Text;

            listaPrestamos.Add(nuevoPrestamo);

            MessageBox.Show("Prestamo solicitado para cliente : " + nuevoPrestamo.cli_DNI);

            this.Close();
        }

        private void estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            estados.Items.Add("Aprobado");
            estados.Items.Add("Cancelado");
            estados.Items.Add("Otro");
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            FrmDestino frmDestino = new FrmDestino();

            if (frmDestino.ShowDialog() == DialogResult.OK)
            {
                if (FrmDestino.Destinos != null && FrmDestino.Destinos.Any())
                {
                    destinoSeleccionado = FrmDestino.Destinos.Last();
                    txtDestinoAsignado.Text = destinoSeleccionado.des_Codigo.ToString();
                }
                else
                {
                    MessageBox.Show("No se ha guardado ningún destino.");
                }
            }
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            FrmPeriodo frmPeriodo = new FrmPeriodo();

            if (frmPeriodo.ShowDialog() == DialogResult.OK)
            {
                periodoSeleccionado = FrmPeriodo.Periodos.Last();
                txtPeriodo.Text = periodoSeleccionado.per_Codigo.ToString();
            }
            else
            {
                MessageBox.Show("No se ha guardado ningún periodo");
            }
        }

    }
}
