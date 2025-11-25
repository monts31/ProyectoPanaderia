using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.Backend
{
    internal class clsProductosConsultas
    {
        public clsProductosConsultas()
        {
        }
        public System.Data.DataTable obtenerProductos()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=lostresbombones; user=root; pwd=31tv9";
            try
            {
                cn.Open();
                string query = "SELECT id_producto, nombre, precio, foto FROM productos";
                MySqlCommand comando = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                System.Data.DataTable tablaProductos = new System.Data.DataTable();
                adapter.Fill(tablaProductos);
                return tablaProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
