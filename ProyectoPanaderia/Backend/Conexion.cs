using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoPanaderia.Backend
{
    public class Conexion
    {

        private static string datos = "server=localhost; database=lostresbombones; user=root; pwd=31tv9";
        public static MySqlConnection conexion()
        {
            return new MySqlConnection(datos);
        }
    }
}
