using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ABMCliente
    {
        public static void altaCliente(Cliente cliente) 
        {
 
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(CLI_DNI, CLI_Nombre, CLI_Apellido, CLI_Sexo, CLI_FechaNacimiento, CLI_Ingresos, CLI_Direccion, CLI_Telefono) values(@dni, @nombre, @apellido, @sexo, @fechaNacimiento, @ingresos, @direccion, @telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cliente.cli_Sexo);
            cmd.Parameters.AddWithValue("@fechaNacimiento", cliente.cli_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", cliente.cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cliente.cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.cli_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable getClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static bool existeDNI(string dni)
        {
            bool existe = false;

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cliente WHERE CLI_DNI = @dni", cn);
                cmd.Parameters.AddWithValue("@dni", dni);

                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                cn.Close();

                existe = (count > 0);
            }

            return existe;
        }


        public static DataTable filtrarClientes(string nombre, string apellido)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"
            SELECT CLI_DNI, CLI_Nombre, CLI_Apellido, CLI_Sexo, CLI_fechaNacimiento, CLI_Ingresos, CLI_Direccion, CLI_Telefono
            FROM Cliente
            WHERE CLI_Apellido LIKE @apellido AND CLI_Nombre LIKE @nombre";

            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

        public static void modificarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"UPDATE Cliente 
                          SET CLI_DNI = @dni, 
                              CLI_Nombre = @nombre, 
                              CLI_Apellido = @apellido, 
                              CLI_Sexo = @sexo, 
                              CLI_fechaNacimiento = @fechaNacimiento,
                              CLI_ingresos = @ingresos,
                              CLI_Direccion = @direccion,
                              CLI_Telefono = @telefono
                          WHERE CLI_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cliente.cli_Sexo);
            cmd.Parameters.AddWithValue("@fechaNacimiento", cliente.cli_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", cliente.cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cliente.cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.cli_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }


        public static void eliminarCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE CLI_DNI = @dni", cnn);

            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static Cliente getClienteByDNI(string dni)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand(
                @"SELECT CLI_DNI, CLI_Nombre, CLI_Apellido 
            FROM Cliente
            WHERE CLI_DNI = @dni", cn);

            cmd.Parameters.AddWithValue("@dni", dni);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Cliente cliente = new Cliente
                {
                    cli_DNI = dr["CLI_DNI"].ToString(),
                    cli_Nombre = dr["CLI_Nombre"].ToString(),
                    cli_Apellido = dr["CLI_Apellido"].ToString()
                };
                cn.Close();
                return cliente;
            }
            cn.Close();
            return null;
            
        }


    }
}
