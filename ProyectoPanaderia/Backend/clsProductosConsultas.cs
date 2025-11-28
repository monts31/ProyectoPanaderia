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
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();

                string query = "SELECT id_producto, nombre, precio,stock, foto FROM productos";

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
        public bool insertarProducto(clsProductos producto, string usuario)
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();

                // asignar variable de sesión del servidor (forma recomendada)
                string userSql = "SELECT @usuarioActual := @usuario;";
                using (var cmdUser = new MySqlCommand(userSql, cn))
                {
                    cmdUser.Parameters.AddWithValue("@usuario", usuario);

                    try
                    {
                        cmdUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Mostrar excepción real para depurar
                        MessageBox.Show("Error al establecer variable de usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // comprobar que la variable quedó establecida (debug)
                try
                {
                    using (var cmdCheck = new MySqlCommand("SELECT @usuarioActual;", cn))
                    {
                        object val = cmdCheck.ExecuteScalar();
                        //MessageBox.Show("Valor @usuarioActual en servidor: " + (val ?? "NULL"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer @usuarioActual: " + ex.Message);
                    // continuar o devolver false según prefieras
                }

                // insertar producto
                string query = "INSERT INTO productos (nombre, descripcion, precio, stock, estado, foto) " +
                               "VALUES (@nombre, @descripcion, @precio, @stock, @estado, @foto)";

                using (var cmd = new MySqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@stock", producto.stock);
                    cmd.Parameters.AddWithValue("@estado", "Activo");
                    cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = (producto.foto != null ? producto.foto : DBNull.Value);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en insertarProducto: " + e.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public bool eliminarProducto(int idProducto, string usuario)
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();

                // asignar variable de sesión del servidor (forma recomendada)
                string userSql = "SELECT @usuarioActual := @usuario;";
                using (var cmdUser = new MySqlCommand(userSql, cn))
                {
                    cmdUser.Parameters.AddWithValue("@usuario", usuario);

                    try
                    {
                        cmdUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Mostrar excepción real para depurar
                        MessageBox.Show("Error al establecer variable de usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // comprobar que la variable quedó establecida (debug)
                try
                {
                    using (var cmdCheck = new MySqlCommand("SELECT @usuarioActual;", cn))
                    {
                        object val = cmdCheck.ExecuteScalar();
                        //MessageBox.Show("Valor @usuarioActual en servidor: " + (val ?? "NULL"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer @usuarioActual: " + ex.Message);
                    // continuar o devolver false según prefieras
                }

                // insertar producto
                string query = "UPDATE productos SET estado = @estado, stock = @stock WHERE id_producto = @id_producto";

                using (var cmd = new MySqlCommand(query, cn))
                {
                    
                    cmd.Parameters.AddWithValue("@estado", "Descontinuado");
                    cmd.Parameters.AddWithValue("@stock", 0);
                    cmd.Parameters.AddWithValue("@id_producto", idProducto);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en eliminarProducto: " + e.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public bool modificarProducto(clsProductos producto, string usuario)
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();

                // asignar variable de sesión del servidor (forma recomendada)
                string userSql = "SELECT @usuarioActual := @usuario;";
                using (var cmdUser = new MySqlCommand(userSql, cn))
                {
                    cmdUser.Parameters.AddWithValue("@usuario", usuario);

                    try
                    {
                        cmdUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Mostrar excepción real para depurar
                        MessageBox.Show("Error al establecer variable de usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // comprobar que la variable quedó establecida (debug)
                try
                {
                    using (var cmdCheck = new MySqlCommand("SELECT @usuarioActual;", cn))
                    {
                        object val = cmdCheck.ExecuteScalar();
                        //MessageBox.Show("Valor @usuarioActual en servidor: " + (val ?? "NULL"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer @usuarioActual: " + ex.Message);
                    // continuar o devolver false según prefieras
                }

                // insertar producto
                string query = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, precio = @precio," +
                    "stock = @stock, estado = @estado, foto = @foto WHERE id_producto = @id_producto";

                using (var cmd = new MySqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id_producto", producto.id_Producto);
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@stock", producto.stock);
                    cmd.Parameters.AddWithValue("@estado", producto.estado);
                    cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = (producto.foto != null ? producto.foto : DBNull.Value);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en modificarProducto: " + e.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
