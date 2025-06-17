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
    public partial class FrmVerUsuarios : Form
    {
        public FrmVerUsuarios()
        {
            InitializeComponent();
        }

        private void FrmVerUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            cargarRoles();
            cargarCbOrdenarPor();
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
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }

        private void cargarUsuarios()
        {
            DataTable dt = ABMUsuario.getUsuarios();

            dgvUsuarios.DataSource = dt;
        }


        private void filtrarUsuarios()
        {
            string nombre = txtNombre.Text == "NOMBRE" ? "" : txtNombre.Text;
            string apellido = txtApellido.Text == "APELLIDO" ? "" : txtApellido.Text;

            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                cargarUsuarios();
                return;
            }

            if (txtNombre.Text == "NOMBRE") txtNombre.Text = "";
            if (txtApellido.Text == "APELLIDO") txtApellido.Text = "";

            dgvUsuarios.DataSource = ABMUsuario.filtrarUsuarios(apellido, nombre);


        }

        private void dgvUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                cbRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["Codigo Rol"].Value.ToString();
                txtApellidoMod.Text = dgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombreMod.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells["Nombre Usuario"].Value.ToString();
                txtPassword.Text = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
            }
            txtNombre.ForeColor = Color.Black;
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
            }
            txtApellido.ForeColor = Color.Black;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);

            bool esAdmin = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Codigo Rol"].Value) == "ADMIN";

            if (esAdmin)
            {
                int cantidadAdmins = ABMUsuario.contarAdministradores();

                if (cantidadAdmins <= 1)
                {
                    MessageBox.Show("No se puede eliminar el último administrador del sistema.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                ABMUsuario.eliminarUsuario(id);

                MessageBox.Show("Usuario eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarUsuarios();
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool esAdmin = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Codigo Rol"].Value) == "ADMIN";
            string nuevoRol = cbRol.SelectedValue.ToString();
            int cantidadAdmins = ABMUsuario.contarAdministradores();
            if (esAdmin && nuevoRol != "ADMIN" && cantidadAdmins <= 1)
            {
                MessageBox.Show("No puede quitar el rol de administrador al único admin del sistema.",
                              "Operación no permitida",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Stop);
                cbRol.SelectedValue = "ADMIN"; 
                return;
            }

            if (string.IsNullOrEmpty(txtNombreMod.Text) || 
                string.IsNullOrEmpty(txtApellidoMod.Text) ||
                string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                cbRol.SelectedValue == null)
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este usuario?", 
                                               "Confirmar Modificación",
                                               MessageBoxButtons.YesNo, 
                                               MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Usuario usuario = new Usuario
            {
                usu_ID  = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value),
                usu_Nombre = txtNombreMod.Text.Trim(),
                usu_Apellido = txtApellidoMod.Text.Trim(),
                usu_Contrasenia = txtPassword.Text, 
                usu_NombreUsuario = txtNombreUsuario.Text.Trim(),
                rol_Codigo = cbRol.SelectedValue.ToString()
            };

            ABMUsuario.modificarUsuario(usuario);

            MessageBox.Show("Usuario modificado correctamente.", "Éxito", 
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            cargarUsuarios();
    
    }

        private void cargarCbOrdenarPor()
        {
            cbOrdenarPor.Items.Add("UserName");
            cbOrdenarPor.Items.Add("Apellido");
        }

        private void cbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbOrdenarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = ABMUsuario.ordenarUsuariosPorUserNameOApellido(cbOrdenarPor.Text);

            dgvUsuarios.DataSource = dt;
        }




    }
}
