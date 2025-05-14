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
    public partial class FrmPeriodo : Form
    {
        public static List<Periodo> Periodos = new List<Periodo>();

        public string CodigoGenerado { get; private set; }
        public string DescripcionPer { get; private set; }

        public FrmPeriodo()
        {
            InitializeComponent();
            GenerarCodigoAleatorio();
        }

        private void GenerarCodigoAleatorio()
        {
            Random random = new Random();
            int codigo = random.Next(1000, 9999); // Número entero aleatorio
            CodigoGenerado = codigo.ToString();
            txtCodPeriodo.Text = CodigoGenerado;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarPeriodo_Click(object sender, EventArgs e)
        {
            DescripcionPer = txtDescripcionPer.Text;

            if (string.IsNullOrEmpty(DescripcionPer))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            Periodo nuevoPeriodo = new Periodo
            {
                per_Codigo = int.Parse(CodigoGenerado),
                per_Descripcion = DescripcionPer
            };

            Periodos.Add(nuevoPeriodo);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
