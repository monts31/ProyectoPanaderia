using MySql.Data.MySqlClient;
using ProyectoPanaderia.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProyectoPanaderia.Backend
{
    internal class clsCompras
    {
        
        public clsCompras() 
        { 
           
        }
        public int registrarOrden(POJO.clsOrdenes orden, DataGridView dgv)
        {
            //codigo para registrar la orden en la base de datos y transaccion
            // Retorna el ID de la orden registrada
            int idOrden = 0;
            //orden.id_Empleado;
            //orden.fecha = DateTime.Now;
            MySqlConnection cn = Conexion.conexion();
            cn.Open();
            
            MySqlTransaction transaction = cn.BeginTransaction();
            try
            {
                //aqui se inserta la orden
                string query = "insert into ordenes (id_Empleado, fecha) values (@id_Empleado, @fecha)";
                MySqlCommand comando = new MySqlCommand(query, cn, transaction);
                comando.Parameters.AddWithValue("@id_Empleado", orden.id_Empleado);
                comando.Parameters.AddWithValue("@fecha", orden.fecha);
                comando.ExecuteNonQuery();
                idOrden = (int)comando.LastInsertedId;


                /// Aqui se van a insertar los detalles de la orden
                string queryDetalle = "insert into dordenes (id_Orden, id_Producto, cantidad, precio) values (@id_Orden, @id_Producto, @cantidad, @precio);";
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow || fila.Cells["IdProducto"].Value == null)
                    {
                        continue; // Ignora esta fila y pasa a la siguiente
                    }
                    MySqlCommand comandoDetalle = new MySqlCommand(queryDetalle, cn, transaction);
                    comandoDetalle.Parameters.AddWithValue("@id_Orden", idOrden);
                    comandoDetalle.Parameters.AddWithValue("@id_Producto", fila.Cells["IdProducto"].Value);
                    comandoDetalle.Parameters.AddWithValue("@cantidad", fila.Cells["cantidad"].Value);
                    comandoDetalle.Parameters.AddWithValue("@precio", fila.Cells["precio"].Value);
                    comandoDetalle.ExecuteNonQuery();

                    string queryActualizarStock = "update productos set stock = stock - @cantidad where id_Producto = @id_Producto;";
                    MySqlCommand comandoActualizarStock = new MySqlCommand(queryActualizarStock, cn, transaction);
                    comandoActualizarStock.Parameters.AddWithValue("@id_Producto", fila.Cells["IdProducto"].Value);
                    comandoActualizarStock.Parameters.AddWithValue("@cantidad", fila.Cells["cantidad"].Value);
                    comandoActualizarStock.ExecuteNonQuery();
                }
                transaction.Commit();
                return idOrden;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Error al registrar la orden: " + ex.Message);
                
            }
            finally
            {
                cn.Close();
            }
           
        }
    }
}
