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

        private static string datos = "server=localhost; database=lostresbombones; user=root; pwd=Dagu12oa";
        public static MySqlConnection conexion()
        {
            return new MySqlConnection(datos);
        }
    }
}
