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

        private static string datos = "server=localhost; database=ventas; user=root; password=Dagu12oa; Allow User Variables=True;";
        public static MySqlConnection conexion()
        {
            return new MySqlConnection(datos);
        }
    }
}
