using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic; 
using ClasesBase;
using ClasesBase.Entidades; 

namespace ClasesBase
{
    public class ABMPrestamo
    {
        // Método para cargar clientes desde la base de datos
        public static DataTable CargarClientes()
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand(); 
            cmd.CommandText = "SELECT CLI_DNI, CLI_Nombre + ' ' + CLI_Apellido AS NombreCompleto FROM Cliente";


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

        // Metodo para devolver los prestamos de la base de datos
        public static DataTable getPrestamos(){
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Prestamo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);

            cn.Close();
            return dt;
        }

        // Metodo para devolver los prestamos de la base de datos usando vista vw_prestamo
        public static DataTable getPrestamosVista()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_prestamo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);

            cn.Close();
            return dt;
        }

        // Metodo para devolver las cuotas asociadas a un prestamo

        public static DataTable getCuotas(int numeroPrestamo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
        SELECT CUO_Codigo, CUO_Numero, CUO_Vencimiento, CUO_Importe, CUO_Estado
        FROM Cuota
        WHERE PRE_Numero = @numeroPrestamo";

            cmd.Parameters.AddWithValue("@numeroPrestamo", numeroPrestamo);
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cn.Open();
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        //Metodo para devolver la descripcion del periodo asociado a un prestamo
        public static Periodo getPeriodoByCodigo(int codigo)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand(
                @"SELECT PER_Descripcion 
            FROM Periodo
            WHERE PER_Codigo = @codigo", cn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Periodo periodo = new Periodo
                {
                    per_Descripcion = dr["PER_Descripcion"].ToString()
                };
                cn.Close();
                return periodo;
            }
            cn.Close();
            return null;

        }


        // Método para insertar un préstamo y sus cuotas en una transacción
        public static int InsertarPrestamoYCuotas(string cliDni, int desCodigo, int perCodigo, DateTime preFecha,
                                                  decimal preImporte, float preTasaInteres, int preCantidadCuotas)
        {
            int prestamoNumero = 0;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlTransaction transaction = null;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();

                SqlCommand cmdPrestamo = new SqlCommand();
                cmdPrestamo.CommandText = "INSERT INTO Prestamo (CLI_DNI, DES_Codigo, PER_Codigo, PRE_Fecha, PRE_Importe, PRE_TasaInteres, PRE_CantidadCuotas, PRE_Estado) " +
                                           "VALUES (@CLI_DNI, @DES_Codigo, @PER_Codigo, @PRE_Fecha, @PRE_Importe, @PRE_TasaInteres, @PRE_CantidadCuotas, @PRE_Estado); " +
                                           "SELECT SCOPE_IDENTITY();";
                cmdPrestamo.CommandType = CommandType.Text;
                cmdPrestamo.Connection = cnn;
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

                decimal interesTotal = preImporte * ((decimal)preTasaInteres / 100.0m);
                decimal montoTotalAPagar = preImporte + interesTotal;
                decimal importePorCuota = montoTotalAPagar / preCantidadCuotas;

                for (int i = 1; i <= preCantidadCuotas; i++)
                {
                    DateTime cuoVencimiento;

                    switch (perCodigo)
                    {
                        case 1: // Semanal
                            cuoVencimiento = preFecha.AddDays(7 * i);
                            break;
                        case 2: // Mensual
                            cuoVencimiento = preFecha.AddMonths(i);
                            break;
                        case 3: // Anual
                            cuoVencimiento = preFecha.AddYears(i);
                            break;
                        default:
                            throw new Exception("Código de período de pago inválido.");
                    }

                    SqlCommand cmdCuota = new SqlCommand();
                    cmdCuota.CommandText = "INSERT INTO Cuota (PRE_Numero, CUO_Numero, CUO_Vencimiento, CUO_Importe, CUO_Estado) " +
                                            "VALUES (@PRE_Numero, @CUO_Numero, @CUO_Vencimiento, @CUO_Importe, @CUO_Estado)";
                    cmdCuota.CommandType = CommandType.Text;
                    cmdCuota.Connection = cnn;
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
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public static DataTable exec_listar_prestamos_por_fecha_sp(DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_prestamos_por_fecha_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_prestamos_por_destino(string destino)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_prestamos_por_destino";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@destino", destino);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int AnularPrestamo(int numeroPrestamo)
        {
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("anularPrestamo", cnn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PRE_Numero", numeroPrestamo);

                    SqlParameter outputParam = new SqlParameter("@EstadoActualizado", SqlDbType.Int);
                    outputParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParam);

                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery(); 

                       if (outputParam.Value != DBNull.Value)
                        {
                            return (int)outputParam.Value; 
                        }
                        else
                        {
                            return -1; 
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error in AnularPrestamo: " + ex.Message);
                        throw;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("General Error in AnularPrestamo: " + ex.Message);
                        throw;
                    }
                }
            }
        }

        public static DataRow obtenerDetallePrestamo(int numeroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "obtenerDetallePrestamo";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@numeroPrestamo", numeroPrestamo);

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalles del préstamo (SP): " + ex.Message);
                throw new Exception("Error al cargar los detalles del préstamo utilizando Stored Procedure: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }


        public static PrestamoEstadisticas obtenerCantPrestamosPorDestino(string destinoDescripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand("obtenerCantPrestamosPorDestino", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@destinoDescripcion", destinoDescripcion);

            PrestamoEstadisticas stats = new PrestamoEstadisticas();

            try
            {
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    stats.CantidadOtorgados = Convert.ToInt32(dr["CantidadOtorgados"]);
                    stats.CantidadPendientes = Convert.ToInt32(dr["CantidadPendientes"]);
                    stats.CantidadCancelados = Convert.ToInt32(dr["CantidadCancelados"]);
                    stats.CantidadAnulados = Convert.ToInt32(dr["CantidadAnulados"]);
                    stats.CantidadTotalPrestamos = Convert.ToInt32(dr["CantidadTotalPrestamos"]);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al obtener estadísticas de préstamos: " + ex.Message);
                throw new Exception("Error al obtener las estadísticas de préstamos por destino. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al obtener estadísticas de préstamos: " + ex.Message);
                throw new Exception("Ocurrió un error inesperado al obtener las estadísticas de préstamos. " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return stats;
        }

        public static DataTable listar_prestamos_por_numero(int nro)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_prestamos_por_nro_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nroPrestamo", nro);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_cuotas_por_numero_prestamo(int nro)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_cuotas_por_nro_prestamo_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nroPrestamo", nro);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        

        public static PrestamoEstadisticas obtenerCantPrestamosPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand("obtenerCantPrestamosPorFecha", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);


            PrestamoEstadisticas stats = new PrestamoEstadisticas();

            try
            {
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    stats.CantidadOtorgados = Convert.ToInt32(dr["CantidadOtorgados"]);
                    stats.CantidadPendientes = Convert.ToInt32(dr["CantidadPendientes"]);
                    stats.CantidadCancelados = Convert.ToInt32(dr["CantidadCancelados"]);
                    stats.CantidadAnulados = Convert.ToInt32(dr["CantidadAnulados"]);
                    stats.CantidadTotalPrestamos = Convert.ToInt32(dr["CantidadTotalPrestamos"]);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al obtener estadísticas de préstamos: " + ex.Message);
                throw new Exception("Error al obtener las estadísticas de préstamos por fecha. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al obtener estadísticas de préstamos: " + ex.Message);
                throw new Exception("Ocurrió un error inesperado al obtener las estadísticas de préstamos. " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return stats;
        }

        public static List<int> listarNroPrestamosPorDNICliente(string dni)
        {
            List<int> numerosPrestamos = new List<int>();

            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString))
            {
                SqlCommand cmd = new SqlCommand("listar_nro_prestamos_por_cliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", dni);

                cnn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    numerosPrestamos.Add(reader.GetInt32(0));
                }

                reader.Close();
            }

            return numerosPrestamos;
        }

        public static DataTable ObtenerResumenCuotasPorClienteYPrestamo(int nroPrestamo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamoConnectionString))
            {
                SqlCommand cmd = new SqlCommand("obtener_cantidad_cuotas_por_nro_prestamo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nroPrestamo", nroPrestamo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

       

    }
}
