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
        private static string connectionString = Properties.Settings.Default.prestamoConnectionString;
        private static SqlConnection connection = new SqlConnection(connectionString);


        public static DataTable getRoles()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            connection.Open();
            da.Fill(dt);

            connection.Close();
            return dt;
        }

        public static DataTable getUsuarios()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_usuario";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            connection.Open();
            da.Fill(dt);

            connection.Close();
            return dt;
        }

        public static void altaUsuario(Usuario usuario)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(USU_NombreUsuario, USU_Contrasenia, USU_Nombre, USU_Apellido , ROL_Codigo) values(@nombreUsuario, @contrasenia, @nombre, @apellido, @rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nombre", usuario.usu_Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.usu_Apellido);
            cmd.Parameters.AddWithValue("@rol", usuario.rol_Codigo);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static bool existeUserName(string userName)
        {
            bool existe = false;

            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE USU_NombreUsuario = @userName", connection);
                cmd.Parameters.AddWithValue("@userName", userName);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                connection.Close();

                existe = (count > 0);
            }

            return existe;
        }

        public static DataTable filtrarUsuarios(string apellido, string nombre)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
            SELECT *
            FROM vw_usuario
            WHERE Apellido LIKE @apellido AND Nombre LIKE @nombre";

            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            connection.Open();
            da.Fill(dt);
            connection.Close();

            return dt;
        }

        public static void eliminarUsuario(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE USU_Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void modificarUsuario(Usuario usuario)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Usuario 
                          SET USU_NombreUsuario = @nombreUsuario, 
                              USU_Nombre = @nombre, 
                              USU_Apellido = @apellido, 
                              USU_Contrasenia = @contrasenia, 
                              ROL_Codigo = @rol
                          WHERE USU_Id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@nombre", usuario.usu_Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.usu_Apellido);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.usu_Contrasenia);
            cmd.Parameters.AddWithValue("@rol", usuario.rol_Codigo);
            cmd.Parameters.AddWithValue("@id", usuario.usu_ID);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static int contarAdministradores()
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE ROL_Codigo = 'ADMIN'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            connection.Open();
            int resultado = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return resultado;
        }

        public static Usuario AutenticarUsuario(string nombreUsuario, string password)
        {
           
            SqlCommand cmd = new SqlCommand(
                @"SELECT USU_Id, USU_NombreUsuario, USU_Nombre, USU_Apellido, ROL_Codigo 
        FROM Usuario 
        WHERE USU_NombreUsuario = @usuario AND USU_Contrasenia = @password", connection);

            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@password", password);

            connection.Open();
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
                connection.Close();
                return usuario;
            }
            connection.Close();
            return null;
            
        }

        public static DataTable ordenarUsuariosPorUserNameOApellido(string filtro)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_usuarios_ordenados_por_username_o_apellido_sp";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@ordenarPor", filtro);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
