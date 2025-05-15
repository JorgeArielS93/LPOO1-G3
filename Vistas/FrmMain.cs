using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAlta = new FrmAltaCliente();
            frmAlta.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo frmPrestamo = new FrmPrestamo();
            frmPrestamo.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult optionSelected = MessageBox.Show("¿Cerrar sesion?", "Aviso", MessageBoxButtons.YesNo);
            if (optionSelected == DialogResult.Yes) {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.FormClosed += (s, args) => this.Close();
                frmLogin.Show();
            }
        }
    }
}