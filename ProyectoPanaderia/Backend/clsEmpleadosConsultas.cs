using MySql.Data.MySqlClient;
using ProyectoPanaderia.POJO;
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

                string sql = "SELECT id_empleado, nombre, usuario, telefono, correo, rol, horas, sueldo, estado FROM empleados;";

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

        public bool insertarEmpleado(clsEmpleados empleado)
        {
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();
                string sql = "call pInsertarEmpleado (@nombre, @usuario, @contraseña, @telefono, @correo, " +
                    "@rol, @horas, @sueldo, @estado);";

                MySqlCommand cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
                cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
                cmd.Parameters.AddWithValue("@contraseña", empleado.contraseña);
                cmd.Parameters.AddWithValue("@telefono", empleado.telefono);
                cmd.Parameters.AddWithValue("@correo", empleado.correo);
                cmd.Parameters.AddWithValue("@rol", empleado.rol);
                cmd.Parameters.AddWithValue("@horas", empleado.horas);
                cmd.Parameters.AddWithValue("@sueldo", empleado.sueldo);
                cmd.Parameters.AddWithValue("@estado", empleado.estado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al insertar el empleado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool modificarEmpleado(clsEmpleados empleado)
        {
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();

                string sql = "call pModificarEmpleado (@id_empleado, @nombre, @usuario, @contraseña, @telefono, @correo, " +
                    "@rol, @horas, @sueldo, @estado);";

                MySqlCommand cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id_empleado", empleado.id_empleado);
                cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
                cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
                cmd.Parameters.AddWithValue("@contraseña", empleado.contraseña);
                cmd.Parameters.AddWithValue("@telefono", empleado.telefono);
                cmd.Parameters.AddWithValue("@correo", empleado.correo);
                cmd.Parameters.AddWithValue("@rol", empleado.rol);
                cmd.Parameters.AddWithValue("@horas", empleado.horas);
                cmd.Parameters.AddWithValue("@sueldo", empleado.sueldo);
                cmd.Parameters.AddWithValue("@estado", empleado.estado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el empleado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool eliminarEmpleado(clsEmpleados empleado)
        {
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();
                string sql = "call pEliminarEmpleado (@id_empleado);";

                MySqlCommand cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id_empleado", empleado.id_empleado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
