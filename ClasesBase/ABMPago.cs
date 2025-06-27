using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ABMPago
    {
        public static DataTable getTodosLosClientes()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_obtenerClientes"; // Llama al Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure; // Indica que es un SP
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loggear el error o mostrar un mensaje)
                Console.WriteLine("Error al obtener clientes: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }

        public static DataTable getPrestamosPendientesPorCliente(string cliDNI)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtenerPrestamosPendientesPorCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@cliDNI", cliDNI); // Pasa el DNI del cliente como parámetro

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener préstamos pendientes: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }

        public static DataTable getCuotasPendientesPorPrestamo(int preNumero)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtenerCuotasPendientesPorPrestamo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@preNumero", preNumero);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener cuotas pendientes: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }

        public static void registrarPago(int cuoCodigo, DateTime pagFecha, decimal pagImporte)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "registrarPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@cuoCodigo", cuoCodigo);
            cmd.Parameters.AddWithValue("@pagFecha", pagFecha);
            cmd.Parameters.AddWithValue("@pagImporte", pagImporte);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                // Si no hay errores, la transacción fue exitosa en el SP
            }
            catch (Exception ex)
            {
                // El SP ya maneja el rollback, aquí solo capturamos el error para informarlo
                throw new Exception("Error al registrar el pago: " + ex.Message, ex);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
    }

    }

