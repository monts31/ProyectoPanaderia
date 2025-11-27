using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.Backend
{
    /// Clase para realizar consultas relacionadas con los empleados en la base de datos.
    public class clsEmpleadosConsultas
    {
        /// Metodo de tipo DataTable para llenar la tabla de empleados, desde la base de datos.
        public DataTable llenarTabla()
        {
            /// Conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT id_Empleado, nombre, rol, usuario, telefono, horas, sueldo, fecha_Contrato FROM empleados;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                da.Fill(dt);

                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al llenar la tabla de productos: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
