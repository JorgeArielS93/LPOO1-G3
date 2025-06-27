using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ABMDestino
    {
        private static string connectionString = Properties.Settings.Default.prestamoConnectionString;

        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void altaDestino(Destino destino)
        {
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "alta_destino_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@descripcion", destino.des_Descripcion);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public static DataTable getDestinos()
        {
           
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_destinos_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificarDestino(Destino destino)
        {
           
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "modificar_destino_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@codigo", destino.des_Codigo);
            cmd.Parameters.AddWithValue("@descripcion", destino.des_Descripcion);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public static void eliminarDestino(int codigo)
        {

            SqlCommand cmd = new SqlCommand("eliminar_destino_sp", connection);

            cmd.CommandType = CommandType.StoredProcedure; 

            cmd.Parameters.AddWithValue("@codigo", codigo);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static Destino getDestinoByCodigo(int codigo)
        {
            
            SqlCommand cmd = new SqlCommand(
                "obtener_destino_por_codigo_sp", connection);

            cmd.CommandType = CommandType.StoredProcedure; 

            cmd.Parameters.AddWithValue("@codigo", codigo);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Destino destino = new Destino
                {
                    des_Descripcion = dr["Descripcion"].ToString()
                };
                connection.Close();
                return destino;
            }
            connection.Close();
            return null;

        }

    }
}
