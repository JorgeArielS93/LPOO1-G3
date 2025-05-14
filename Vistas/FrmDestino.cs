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
    public partial class FrmDestino : Form
    {

        public static List<Destino> Destinos = new List<Destino>();

        public string CodigoGenerado { get; private set; }
        public string DescripcionDes { get; private set; }

        public FrmDestino()
        {
            InitializeComponent();
            GenerarCodigoAleatorio();
        }

        private void GenerarCodigoAleatorio()
        {
            Random random = new Random();
            int codigo = random.Next(1000, 9999); // Número entero aleatorio
            CodigoGenerado = codigo.ToString();
            txtCodDestino.Text = CodigoGenerado;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarDestino_Click(object sender, EventArgs e)
        {
            DescripcionDes = txtDescripcionDest.Text;

            if (string.IsNullOrEmpty(DescripcionDes))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            Destino nuevoDestino = new Destino
            {
                des_Codigo = int.Parse(CodigoGenerado),
                des_Descripcion = DescripcionDes
            };

            Destinos.Add(nuevoDestino);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
    }
}
