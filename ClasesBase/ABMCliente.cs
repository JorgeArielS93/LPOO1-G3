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
        private static string connectionString = Properties.Settings.Default.prestamoConnectionString;

        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void altaCliente(Cliente cliente) 
        {
 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(CLI_DNI, CLI_Nombre, CLI_Apellido, CLI_Sexo, CLI_FechaNacimiento, CLI_Ingresos, CLI_Direccion, CLI_Telefono) values(@dni, @nombre, @apellido, @sexo, @fechaNacimiento, @ingresos, @direccion, @telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@dni", cliente.cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cliente.cli_Sexo);
            cmd.Parameters.AddWithValue("@fechaNacimiento", cliente.cli_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", cliente.cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cliente.cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.cli_Telefono);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable getClientes()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM vw_cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("NombreCompleto", typeof(string), "Nombre + ' ' + Apellido");

            return dt;

        }

        public static bool existeDNI(string dni)
        {
            bool existe = false;

            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cliente WHERE CLI_DNI = @dni", connection);
                cmd.Parameters.AddWithValue("@dni", dni);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                connection.Close();

                existe = (count > 0);
            }

            return existe;
        }

        public static DataTable filtrarClientes(string nombre, string apellido)
        {
           
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"
            SELECT *
            FROM vw_cliente
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

        public static void modificarCliente(Cliente cliente)
        {
           
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
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@dni", cliente.cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cliente.cli_Sexo);
            cmd.Parameters.AddWithValue("@fechaNacimiento", cliente.cli_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", cliente.cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cliente.cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.cli_Telefono);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public static void eliminarCliente(string dni)
        {

            SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE CLI_DNI = @dni", connection);

            cmd.Parameters.AddWithValue("@dni", dni);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public static Cliente getClienteByDNI(string dni)
        {
            
            SqlCommand cmd = new SqlCommand(
                @"SELECT CLI_DNI, CLI_Nombre, CLI_Apellido 
            FROM Cliente
            WHERE CLI_DNI = @dni", connection);

            cmd.Parameters.AddWithValue("@dni", dni);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Cliente cliente = new Cliente
                {
                    cli_DNI = dr["CLI_DNI"].ToString(),
                    cli_Nombre = dr["CLI_Nombre"].ToString(),
                    cli_Apellido = dr["CLI_Apellido"].ToString()
                };
                connection.Close();
                return cliente;
            }
            connection.Close();
            return null;
            
        }

        public static DataTable ordenarClientesPorApellido()
        {
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_clientes_ordenados_por_apellidos_sp";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable getPagosDeClientes(string dni)
        {
            SqlCommand cmd = new SqlCommand("listar_pagos_clientes_sp",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
