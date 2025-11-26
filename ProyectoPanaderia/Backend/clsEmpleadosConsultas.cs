using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.Backend
{
    public class clsEmpleadosConsultas
    {
        public DataTable llenarTabla()
        {
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
