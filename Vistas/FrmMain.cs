using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using Vistas.VistaCliente;
using Vistas.VistaDestino;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain(Usuario usuario)
        {
            InitializeComponent();
            configurarPermisos(usuario.rol_Codigo);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void configurarPermisos(string rol)
        {
            usuarioToolStripMenuItem.Visible = false;
            destinosToolStripMenuItem.Visible = false;
            periodosToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;
            prestamosToolStripMenuItem.Visible = false;
            pagosToolStripMenuItem.Visible = false;

            switch (rol)
            {
                case "ADMIN":
                    usuarioToolStripMenuItem.Visible = true;
                    destinosToolStripMenuItem.Visible = true;
                    periodosToolStripMenuItem.Visible = true;
                    break;
                
                case "OPER":
                    clientesToolStripMenuItem.Visible = true;
                    prestamosToolStripMenuItem.Visible = true;
                    pagosToolStripMenuItem.Visible = true;
                    break;
                
                case "AUDI":
                    usuarioToolStripMenuItem.Visible = true;
                    destinosToolStripMenuItem.Visible = true;
                    periodosToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    prestamosToolStripMenuItem.Visible = true;
                    pagosToolStripMenuItem.Visible = true;
                    break;
            }
             
            lblUsuario.Text = "Usuario: " + FrmLogin.UsuarioLogueado.usu_Nombre + " " + FrmLogin.UsuarioLogueado.usu_Apellido;
            lblRol.Text = "Rol: " + obtenerDescripcionRol(FrmLogin.UsuarioLogueado.rol_Codigo);
        }

        private string obtenerDescripcionRol(string codigoRol)
        {
            switch (codigoRol)
            {
                case "ADMIN": return "Administrador";
                case "OPER": return "Operador";
                case "AUDI": return "Auditor";
                default: return "Sin rol asignado";
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo frmPrestamo = new FrmPrestamo();
            frmPrestamo.Show();
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

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario();
            frmAlta.Show();

        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerUsuarios frmVer = new FrmVerUsuarios();
            frmVer.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAlta = new FrmAltaCliente();
            frmAlta.Show();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerClientes frmVerC = new FrmVerClientes();
            frmVerC.Show();
        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAltaDestino frmAltaDes = new FrmAltaDestino();
            frmAltaDes.Show();
        }

        private void verDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerDestinos frmVerDes = new FrmVerDestinos();
            frmVerDes.Show();
        }

       

       

    }
}
