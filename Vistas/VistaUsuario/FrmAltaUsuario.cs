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
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRoles();

        }
        
        private void cargarRoles()
        {

            DataTable dt = ABMUsuario.getRoles();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron roles.");
                return;
            }

            cbRol.DisplayMember = "ROL_Descripcion";
            cbRol.ValueMember = "ROL_Codigo";
            cbRol.DataSource = dt;
            cbRol.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            Usuario oUsuario = crearUsuario();
            ABMUsuario.altaUsuario(oUsuario);

            MessageBox.Show("Se creo el usuario " + txtNombre.Text + " correctamente");
        }

        private Usuario crearUsuario()
        {
            Usuario nuevoUsuario = new Usuario();
     
            nuevoUsuario.usu_NombreUsuario = txtNombreUsuario.Text;
            nuevoUsuario.usu_Nombre = txtNombre.Text;
            nuevoUsuario.usu_Apellido = txtApellido.Text;
            nuevoUsuario.usu_Contrasenia = txtPassword.Text;
            nuevoUsuario.rol_Codigo = (string)cbRol.SelectedValue;

            return nuevoUsuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            if (cbRol.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
