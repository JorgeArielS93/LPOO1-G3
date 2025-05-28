using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ABMUsuario
    {

        public static DataTable getRoles()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);

            cn.Close();
            return dt;
        }

        public static DataTable getUsuarios()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);

            cn.Close();
            return dt;
        }

        public static void altaUsuario(Usuario usuario)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(USU_NombreUsuario, USU_Contrasenia, USU_Nombre, USU_Apellido , ROL_Codigo) values(@nombreUsuario, @contrasenia, @nombre, @apellido, @rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nombre", usuario.usu_Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.usu_Apellido);
            cmd.Parameters.AddWithValue("@rol", usuario.rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable filtrarUsuarios(string apellido, string nombre)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
        SELECT USU_Id, USU_NombreUsuario, USU_Nombre, USU_Apellido, ROL_Codigo, USU_Contrasenia
        FROM Usuario
        WHERE USU_Apellido LIKE @apellido AND USU_Nombre LIKE @nombre";

            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cn.Open();
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        public static void eliminarUsuario(int id)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE USU_Id = @id", cn);
            cmd.Parameters.AddWithValue("@id", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void modificarUsuario(Usuario usuario)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Usuario 
                          SET USU_NombreUsuario = @nombreUsuario, 
                              USU_Nombre = @nombre, 
                              USU_Apellido = @apellido, 
                              USU_Contrasenia = @contrasenia, 
                              ROL_Codigo = @rol
                          WHERE USU_Id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@nombre", usuario.usu_Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.usu_Apellido);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.usu_Contrasenia);
            cmd.Parameters.AddWithValue("@rol", usuario.rol_Codigo);
            cmd.Parameters.AddWithValue("@id", usuario.usu_ID);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static int contarAdministradores()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE ROL_Codigo = 'ADMIN'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cn.Open();
            int resultado = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            return resultado;
        }

        public static Usuario AutenticarUsuario(string nombreUsuario, string password)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand(
                @"SELECT USU_Id, USU_NombreUsuario, USU_Nombre, USU_Apellido, ROL_Codigo 
        FROM Usuario 
        WHERE USU_NombreUsuario = @usuario AND USU_Contrasenia = @password", cn);

            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@password", password);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Usuario usuario = new Usuario
                {
                    usu_ID = Convert.ToInt32(dr["USU_Id"]),
                    usu_NombreUsuario = dr["USU_NombreUsuario"].ToString(),
                    usu_Nombre = dr["USU_Nombre"].ToString(),
                    usu_Apellido = dr["USU_Apellido"].ToString(),
                    rol_Codigo = dr["ROL_Codigo"].ToString()
                };
                cn.Close();
                return usuario;
            }
            cn.Close();
            return null;
            
        }

    }
}
