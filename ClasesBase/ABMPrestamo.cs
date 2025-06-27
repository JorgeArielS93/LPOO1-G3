using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic; 
using ClasesBase;
using System.Text; 

namespace ClasesBase
{
    public class ABMPrestamo
    {
        private static string connectionString = Properties.Settings.Default.prestamoConnectionString;
        private static SqlConnection connection = new SqlConnection(connectionString);
        // Método para cargar clientes desde la base de datos
        public static DataTable CargarClientes()
        {


            SqlCommand cmd = new SqlCommand(); 
            cmd.CommandText = "SELECT CLI_DNI, CLI_Nombre + ' ' + CLI_Apellido AS NombreCompleto FROM Cliente";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            connection.Open();
            da.Fill(dt);

            connection.Close();
            return dt;
        }

        // Método para cargar destinos desde la base de datos
        public static DataTable CargarDestinos()
        {
            
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT DES_Codigo, DES_Descripcion FROM Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            try
            {
                connection.Open();
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return dt;
        }

        // Método para cargar periodos desde la base de datos
        public static DataTable CargarPeriodos()
        {
           
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT PER_Codigo, PER_Descripcion FROM Periodo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            try
            {
                connection.Open();
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return dt;
        }

        // Metodo para devolver los prestamos de la base de datos
        public static DataTable getPrestamos(){
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Prestamo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            connection.Open();
            da.Fill(dt);

            connection.Close();
            return dt;
        }

        public static DataTable filtrarPrestamos(int codigoDestinoSeleccionado , DateTime desde, DateTime hasta)
        {
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    // Base del query
                    StringBuilder query = new StringBuilder("SELECT * FROM Prestamo WHERE 1=1");

                    // Agregamos filtros dinámicamente
                    if (codigoDestinoSeleccionado > 0)
                    {
                        query.Append(" AND DES_Codigo = @codigoDestino");
                        cmd.Parameters.AddWithValue("@codigoDestino", codigoDestinoSeleccionado);
                    }

                    if (desde != DateTime.MinValue && hasta != DateTime.MaxValue)
                    {
                        query.Append(" AND PRE_Fecha BETWEEN @fechaDesde AND @fechaHasta");
                        cmd.Parameters.AddWithValue("@fechaDesde", desde);
                        cmd.Parameters.AddWithValue("@fechaHasta", hasta);
                    }

                    cmd.CommandText = query.ToString();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        connection.Open();
                        da.Fill(dt);
                        connection.Close();
                        return dt;
                    }
                }
            }
            
        }

        // Metodo para devolver las cuotas asociadas a un prestamo

        public static DataTable getCuotas(int numeroPrestamo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
        SELECT CUO_Codigo, CUO_Numero, CUO_Vencimiento, CUO_Importe, CUO_Estado
        FROM Cuota
        WHERE PRE_Numero = @numeroPrestamo";

            cmd.Parameters.AddWithValue("@numeroPrestamo", numeroPrestamo);
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            connection.Open();
            da.Fill(dt);
            connection.Close();

            return dt;
        }

        //Metodo para devolver la descripcion del periodo asociado a un prestamo
        public static Periodo getPeriodoByCodigo(int codigo)
        {
            SqlCommand cmd = new SqlCommand(
                @"SELECT PER_Descripcion 
            FROM Periodo
            WHERE PER_Codigo = @codigo", connection);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Periodo periodo = new Periodo
                {
                    per_Descripcion = dr["PER_Descripcion"].ToString()
                };
                connection.Close();
                return periodo;
            }
            connection.Close();
            return null;

        }


        // Método para insertar un préstamo y sus cuotas en una transacción
        public static int InsertarPrestamoYCuotas(
            string cliDni, int desCodigo, int perCodigo, DateTime preFecha,
            decimal preImporte, float preTasaInteres, int preCantidadCuotas)
        {
            int prestamoNumero = 0; 

            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction(); 

                SqlCommand cmdPrestamo = new SqlCommand();
                cmdPrestamo.CommandText = "INSERT INTO Prestamo (CLI_DNI, DES_Codigo, PER_Codigo, PRE_Fecha, PRE_Importe, PRE_TasaInteres, PRE_CantidadCuotas, PRE_Estado) " +
                                           "VALUES (@CLI_DNI, @DES_Codigo, @PER_Codigo, @PRE_Fecha, @PRE_Importe, @PRE_TasaInteres, @PRE_CantidadCuotas, @PRE_Estado); " +
                                           "SELECT SCOPE_IDENTITY();"; 
                cmdPrestamo.CommandType = CommandType.Text;
                cmdPrestamo.Connection = connection;
                cmdPrestamo.Transaction = transaction; 

                cmdPrestamo.Parameters.AddWithValue("@CLI_DNI", cliDni);
                cmdPrestamo.Parameters.AddWithValue("@DES_Codigo", desCodigo);
                cmdPrestamo.Parameters.AddWithValue("@PER_Codigo", perCodigo);
                cmdPrestamo.Parameters.AddWithValue("@PRE_Fecha", preFecha);
                cmdPrestamo.Parameters.AddWithValue("@PRE_Importe", preImporte);
                cmdPrestamo.Parameters.AddWithValue("@PRE_TasaInteres", preTasaInteres);
                cmdPrestamo.Parameters.AddWithValue("@PRE_CantidadCuotas", preCantidadCuotas);
                cmdPrestamo.Parameters.AddWithValue("@PRE_Estado", "PENDIENTE");

                prestamoNumero = Convert.ToInt32(cmdPrestamo.ExecuteScalar()); 

                decimal importePorCuota = preImporte / preCantidadCuotas;

                for (int i = 1; i <= preCantidadCuotas; i++)
                {
                    DateTime cuoVencimiento = preFecha.AddMonths(i);

                    SqlCommand cmdCuota = new SqlCommand();
                    cmdCuota.CommandText = "INSERT INTO Cuota (PRE_Numero, CUO_Numero, CUO_Vencimiento, CUO_Importe, CUO_Estado) " +
                                            "VALUES (@PRE_Numero, @CUO_Numero, @CUO_Vencimiento, @CUO_Importe, @CUO_Estado)";
                    cmdCuota.CommandType = CommandType.Text;
                    cmdCuota.Connection = connection;
                    cmdCuota.Transaction = transaction; 

                    cmdCuota.Parameters.AddWithValue("@PRE_Numero", prestamoNumero);
                    cmdCuota.Parameters.AddWithValue("@CUO_Numero", i);
                    cmdCuota.Parameters.AddWithValue("@CUO_Vencimiento", cuoVencimiento);
                    cmdCuota.Parameters.AddWithValue("@CUO_Importe", importePorCuota);
                    cmdCuota.Parameters.AddWithValue("@CUO_Estado", "PENDIENTE");

                    cmdCuota.ExecuteNonQuery();
                }

                transaction.Commit(); 
                return prestamoNumero; 
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
