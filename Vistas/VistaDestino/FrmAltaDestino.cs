using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas.VistaDestino
{
    public partial class FrmAltaDestino : Form
    {
        public FrmAltaDestino()
        {
            InitializeComponent();
        }

        private void FrmAltaDestino_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("El campo destino es obligatorio.");
                return;
            }

            Destino destino = new Destino();
            destino.des_Descripcion = txtDestino.Text;

            ABMDestino.altaDestino(destino);
            MessageBox.Show("Destino creado con exito!");

            this.Close();

        }
    }
}
