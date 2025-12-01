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

                /// Consulta SQL para seleccionar los campos necesarios de la tabla empleados.
                string sql = "SELECT id_empleado, nombre, usuario, telefono, correo, rol, horas, sueldo, estado FROM empleados;";

                /// Adaptador de datos para ejecutar la consulta y llenar el DataTable.
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                da.Fill(dt);

                /// Cerrar la conexion y retornar el DataTable lleno.
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

        /// Metodo para insertar un nuevo empleado en la base de datos.
        public bool insertarEmpleado(clsEmpleados empleado)
        {
            /// Se crea una instancia de la conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                /// Abrir la conexion.
                cn.Open();
                /// Consulta SQL para llamar al procedimiento almacenado de insercion de empleado.
                string sql = "call pInsertarEmpleado (@nombre, @usuario, @contraseña, @telefono, @correo, " +
                    "@rol, @horas, @sueldo, @estado);";

                /// Comando SQL para ejecutar la consulta.
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                /// Agregar los parametros necesarios para el procedimiento almacenado.
                cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
                cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
                cmd.Parameters.AddWithValue("@contraseña", empleado.contraseña);
                cmd.Parameters.AddWithValue("@telefono", empleado.telefono);
                cmd.Parameters.AddWithValue("@correo", empleado.correo);
                cmd.Parameters.AddWithValue("@rol", empleado.rol);
                cmd.Parameters.AddWithValue("@horas", empleado.horas);
                cmd.Parameters.AddWithValue("@sueldo", empleado.sueldo);
                cmd.Parameters.AddWithValue("@estado", empleado.estado);

                /// Ejecutar el comando y verificar si se afecto alguna fila.
                /// retornar true si se inserto correctamente, false en caso contrario.
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al insertar el empleado: " + ex.Message);
            }
            finally
            {
                /// Cerrar la conexion.
                cn.Close();
            }
        }

        /// Metodo para modificar un empleado existente en la base de datos.
        public bool modificarEmpleado(clsEmpleados empleado)
        {
            /// Conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                /// Abrir la conexion.
                cn.Open();

                /// Consulta SQL para llamar al procedimiento almacenado de modificacion de empleado.
                string sql = "call pModificarEmpleado (@id_empleado, @nombre, @usuario, @contraseña, @telefono, @correo, " +
                    "@rol, @horas, @sueldo, @estado);";

                /// Comando SQL para ejecutar la consulta.
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                /// Agregar los parametros necesarios para el procedimiento almacenado.
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

                /// Ejecutar el comando y verificar si se afecto alguna fila.
                /// Se retorna true si se modifico correctamente, false en caso contrario.
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el empleado: " + ex.Message);
            }
            finally
            {
                /// Cerrar la conexion.
                cn.Close();
            }
        }

        /// Metodo para realzar el borrado logico de un empleado de la base de datos.
        public bool eliminarEmpleado(clsEmpleados empleado)
        {
            /// instancia de la conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                /// abrir la conexion.
                cn.Open();

                /// Consulta SQL para llamar al procedimiento almacenado que se encarga de la eliminacion de empleado.
                string sql = "call pEliminarEmpleado (@id_empleado);";

                /// Comando SQL para ejecutar la consulta.
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                /// Agregar el parametro necesario para el procedimiento almacenado.
                cmd.Parameters.AddWithValue("@id_empleado", empleado.id_empleado);

                /// Ejecutar el comando y verificar si se afecto alguna fila.
                /// Devuelve true si se elimino correctamente, false en caso contrario.
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                /// Cerrar la conexion.
                cn.Close();
            }
        }
    }
}
