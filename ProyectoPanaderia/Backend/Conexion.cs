using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoPanaderia.Backend
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {

            string servidor = "localhost";
            string bd = "login";
            string usuario = "root";
            string contraseña = "31tv9";

            string cadenaconexion = "Database=" + bd + "; Data source=" + servidor + "; user id="
                + usuario + "; password=" + contraseña;

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return null;
            }

        }
    }
}
