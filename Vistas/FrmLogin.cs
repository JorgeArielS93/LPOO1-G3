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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private List<Rol> cargarRoles()
        {
            return new List<Rol> {
                                    new Rol("ADMIN", "Administrador"),
                                    new Rol("OPER", "Operador"),
                                    new Rol("AUD", "Auditor")};
        }

        private List<Usuario> cargarUsuarios()
        {
            return new List<Usuario> {
                                        new Usuario(1, "admin", "123", "Juan Pérez", "ADMIN"),
                                        new Usuario(2, "operador", "123", "Lucía Gómez", "OPER"),
                                        new Usuario(3, "auditor", "123", "Martín Díaz", "AUD")};
        }
    
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Boolean usuarioValido = false;
            List<Usuario> usuarios = cargarUsuarios();
            List<Rol> roles = cargarRoles();
            string nombreIngresado = txtUserName.Text;
            string passwordIngresado = txtPassword.Text;
            string rolUsuario = "";
            FrmMain oFrmMain = new FrmMain();

            foreach(Usuario usuario in usuarios){
                if(usuario.usu_NombreUsuario == nombreIngresado && usuario.usu_Contraseña == passwordIngresado){
                    usuarioValido = true;
                    foreach (Rol rol in roles){
                        if(usuario.rol_Codigo == rol.rol_Codigo){
                            rolUsuario = rol.rol_Descripcion;
                        }

                    }
                    MessageBox.Show("Bienvenido/a: " + usuario.usu_ApellidoNombre +
                                                    "\nRol: " + rolUsuario);

                    this.Hide(); 
                    oFrmMain.FormClosed += (s, args) => this.Close(); 
                    oFrmMain.Show();
                    
                    break;
                }
            }
            
            if(!usuarioValido){
                MessageBox.Show("Credenciales incorrectas");
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "NOMBRE DE USUARIO")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
