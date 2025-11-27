using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoPanaderia.POJO;

namespace ProyectoPanaderia.Backend
{
    public class clsLogin
    {
        public bool IniciarSesion(clsEmpleados empleado)
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();

                /// creamos el comando SQL para verificar que los datos del usuario existan en la base de datos   
                string query = "SELECT * FROM empleados WHERE  usuario = @usuario AND contraseña = SHA1(@contraseña)";
                MySqlCommand comando = new MySqlCommand(query, cn);
                comando.Parameters.AddWithValue("@usuario", empleado.usuario);
                comando.Parameters.AddWithValue("@contraseña",empleado.contraseña);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        empleado.usuario = reader["usuario"].ToString();
                        empleado.rol = reader["rol"].ToString();
                        empleado.nombre = reader["nombre"].ToString();
                        empleado.id_Empleado = Convert.ToInt32(reader["id_Empleado"]);
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return false;
            }
            finally { cn.Close(); }

        }
    }
}
