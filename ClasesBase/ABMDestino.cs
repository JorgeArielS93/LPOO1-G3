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

        public static void altaDestino(Destino destino)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Destino(DES_Descripcion) values(@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", destino.des_Descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable getDestinos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificarDestino(Destino destino)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"UPDATE Destino 
                              SET DES_Descripcion = @descripcion
                              WHERE DES_Codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", destino.des_Codigo);
            cmd.Parameters.AddWithValue("@descripcion", destino.des_Descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void eliminarDestino(int codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Destino WHERE DES_Codigo = @codigo", cnn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
