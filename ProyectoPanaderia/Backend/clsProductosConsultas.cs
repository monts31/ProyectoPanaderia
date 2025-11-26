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
    internal class clsProductosConsultas
    {
        public clsProductosConsultas()
        {
        }
        public System.Data.DataTable obtenerProductos()
        {
            //MySqlConnection cn = new MySqlConnection();
            //cn.ConnectionString = "server=localhost; database=lostresbombones; user=root; pwd=Dagu12oa";
            MySqlConnection cn = Conexion.conexion();

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

        public DataTable llenarTabla()
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM productos";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                da.Fill(dt);

                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al llenar la tabla de productos: " + ex.Message);
            }finally {                 
                cn.Close(); 
            }
        }

        public bool insertarProducto(clsProductos producto)
        {
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();
                string query = "INSERT INTO productos (nombre, descripcion, precio, stock, foto) VALUES (@nombre, @descripcion, @precio, @stock, @foto)";

                MySqlCommand comando = new MySqlCommand(query, cn);

                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@precio", producto.precio);
                comando.Parameters.AddWithValue("@stock", producto.stock);
                comando.Parameters.AddWithValue("@foto", producto.foto);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el producto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool eliminarProducto(int idProducto)
        {
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();
                string query = "DELETE FROM productos WHERE id_producto = @idProducto";

                MySqlCommand comando = new MySqlCommand(query, cn);

                comando.Parameters.AddWithValue("@idProducto", idProducto);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool modificarProducto(clsProductos producto)
        {
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();
                string query = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, precio = @precio, stock = @stock, foto = @foto " +
                                "WHERE id_producto = @id_producto";

                MySqlCommand comando = new MySqlCommand(query, cn);

                comando.Parameters.AddWithValue("@id_producto", producto.id_Producto);
                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@precio", producto.precio);
                comando.Parameters.AddWithValue("@stock", producto.stock);
                //comando.Parameters.AddWithValue("@foto", new byte[] { });

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el producto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
