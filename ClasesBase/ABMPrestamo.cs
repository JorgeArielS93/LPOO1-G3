using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic; // Aunque no se use directamente aquí, es una buena práctica incluirla si se manejan colecciones
using ClasesBase; // Asegúrate de que este namespace sea el de tu proyecto ClasesBase

namespace ClasesBase
{
    public class ABMPrestamo
    {
        // Método para cargar clientes desde la base de datos
        public static DataTable CargarClientes()
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

        // Método para cargar destinos desde la base de datos
        public static DataTable CargarDestinos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT DES_Codigo, DES_Descripcion FROM Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al cargar destinos: " + ex.Message);
                throw new Exception("Error al cargar la lista de destinos. Por favor, intente de nuevo más tarde.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al cargar destinos: " + ex.Message);
                throw new Exception("Ocurrió un error inesperado al cargar los destinos.");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return dt;
        }

        // Método para cargar periodos desde la base de datos
        public static DataTable CargarPeriodos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT PER_Codigo, PER_Descripcion FROM Periodo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al cargar periodos: " + ex.Message);
                throw new Exception("Error al cargar la lista de períodos. Por favor, intente de nuevo más tarde.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al cargar periodos: " + ex.Message);
                throw new Exception("Ocurrió un error inesperado al cargar los períodos.");
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return dt;
        }

        // Método para insertar un préstamo y sus cuotas en una transacción
        public static int InsertarPrestamoYCuotas(
            string cliDni, int desCodigo, int perCodigo, DateTime preFecha,
            decimal preImporte, float preTasaInteres, int preCantidadCuotas)
        {
            int prestamoNumero = 0; // Para almacenar el ID del préstamo insertado

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlTransaction transaction = null;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction(); // Iniciar una transacción

                // 1. Insertar en la tabla Prestamo
                SqlCommand cmdPrestamo = new SqlCommand();
                cmdPrestamo.CommandText = "INSERT INTO Prestamo (CLI_DNI, DES_Codigo, PER_Codigo, PRE_Fecha, PRE_Importe, PRE_TasaInteres, PRE_CantidadCuotas, PRE_Estado) " +
                                           "VALUES (@CLI_DNI, @DES_Codigo, @PER_Codigo, @PRE_Fecha, @PRE_Importe, @PRE_TasaInteres, @PRE_CantidadCuotas, @PRE_Estado); " +
                                           "SELECT SCOPE_IDENTITY();"; // Para obtener el ID autoincremental
                cmdPrestamo.CommandType = CommandType.Text;
                cmdPrestamo.Connection = cnn;
                cmdPrestamo.Transaction = transaction; // Asignar la transacción

                cmdPrestamo.Parameters.AddWithValue("@CLI_DNI", cliDni);
                cmdPrestamo.Parameters.AddWithValue("@DES_Codigo", desCodigo);
                cmdPrestamo.Parameters.AddWithValue("@PER_Codigo", perCodigo);
                cmdPrestamo.Parameters.AddWithValue("@PRE_Fecha", preFecha);
                cmdPrestamo.Parameters.AddWithValue("@PRE_Importe", preImporte);
                cmdPrestamo.Parameters.AddWithValue("@PRE_TasaInteres", preTasaInteres);
                cmdPrestamo.Parameters.AddWithValue("@PRE_CantidadCuotas", preCantidadCuotas);
                cmdPrestamo.Parameters.AddWithValue("@PRE_Estado", "PENDIENTE");

                prestamoNumero = Convert.ToInt32(cmdPrestamo.ExecuteScalar()); // Ejecutar y obtener el ID

                // 2. Insertar en la tabla Cuota (en un bucle)
                decimal importePorCuota = preImporte / preCantidadCuotas;

                for (int i = 1; i <= preCantidadCuotas; i++)
                {
                    DateTime cuoVencimiento = preFecha.AddMonths(i);

                    SqlCommand cmdCuota = new SqlCommand();
                    cmdCuota.CommandText = "INSERT INTO Cuota (PRE_Numero, CUO_Numero, CUO_Vencimiento, CUO_Importe, CUO_Estado) " +
                                            "VALUES (@PRE_Numero, @CUO_Numero, @CUO_Vencimiento, @CUO_Importe, @CUO_Estado)";
                    cmdCuota.CommandType = CommandType.Text;
                    cmdCuota.Connection = cnn;
                    cmdCuota.Transaction = transaction; // Asignar la transacción

                    cmdCuota.Parameters.AddWithValue("@PRE_Numero", prestamoNumero);
                    cmdCuota.Parameters.AddWithValue("@CUO_Numero", i);
                    cmdCuota.Parameters.AddWithValue("@CUO_Vencimiento", cuoVencimiento);
                    cmdCuota.Parameters.AddWithValue("@CUO_Importe", importePorCuota);
                    cmdCuota.Parameters.AddWithValue("@CUO_Estado", "PENDIENTE");

                    cmdCuota.ExecuteNonQuery();
                }

                transaction.Commit(); // Confirmar la transacción
                return prestamoNumero; // Retornar el ID del préstamo creado
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                {
                    try { transaction.Rollback(); }
                    catch (Exception rbEx) { Console.WriteLine("Rollback Exception: " + rbEx.Message); }
                }
                Console.WriteLine("Error SQL al guardar préstamo: " + ex.Message);
                throw new Exception("Error en la base de datos al registrar el préstamo y sus cuotas. " + ex.Message);
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    try { transaction.Rollback(); }
                    catch (Exception rbEx) { Console.WriteLine("Rollback Exception: " + rbEx.Message); }
                }
                Console.WriteLine("Error general al guardar préstamo: " + ex.Message);
                throw new Exception("Ocurrió un error inesperado al guardar el préstamo y sus cuotas. " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
    }
}
