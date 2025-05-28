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
        public static Usuario UsuarioLogueado { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

       
    
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Validación", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = ABMUsuario.AutenticarUsuario(nombreUsuario, password);

            if (usuario != null)
            {
                UsuarioLogueado = usuario;

                MessageBox.Show("Bienvenido/a: " + usuario.usu_Nombre + " " + usuario.usu_Apellido + "\n" +
                "Rol: " + obtenerDescripcionRol(usuario.rol_Codigo),
                "Acceso concedido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                FrmMain mainForm = new FrmMain(usuario);
                this.Hide();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Acceso denegado", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
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
        private Color colorOriginal;
        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            colorOriginal = btnIngresar.BackColor;
            btnIngresar.BackColor = Color.DarkBlue;
            btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = colorOriginal;
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            colorOriginal = btnSalir.BackColor;
            btnSalir.BackColor = Color.DarkRed;
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = colorOriginal;
            btnSalir.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*') 
            {
                button1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
