using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.Backend
{
    public class clsAuditorias
    {
        public clsAuditorias() { }

        public System.Data.DataTable obtenerAuditoria()
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();
                string query = "SELECT * FROM auditorias";
                MySqlCommand comando = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                System.Data.DataTable tablaAuditorias = new System.Data.DataTable();
                adapter.Fill(tablaAuditorias);
                return tablaAuditorias;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable reporte(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();
            string query = "select p.id_producto, p.nombre, sum(d.cantidad) as cantidad, sum(d.precio* d.cantidad) as monto\r\nfrom detalles d inner join productos p on d.id_Producto = p.id_producto\r\ninner join ordenes o on o.id_Orden = d.id_Orden where date(o.fecha) between @fechaInicio and @fechaFin\r\ngroup by p.id_producto, p.nombre order by cantidad desc;";
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();
                MySqlCommand comando = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                comando.Parameters.AddWithValue("@fechaInicio", inicio);
                comando.Parameters.AddWithValue("@fechaFin", fin);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el reporte: " + ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }

    }
}