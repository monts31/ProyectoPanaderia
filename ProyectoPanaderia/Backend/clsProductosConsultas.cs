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
    public class clsProductosConsultas
    {
        public clsProductosConsultas()
        {
        }

        /// Metodo para obtener los productos activos desde la base de datos.
        public System.Data.DataTable obtenerProductos()
        {
            /// Conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                /// Abrir la conexion.
                cn.Open();

                /// Consulta SQL para seleccionar los productos activos.
                string query = "SELECT id_producto, nombre, precio,stock, foto FROM productos where estado='Activo'";

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
                /// Cerrar la conexion.
                cn.Close();
            }
        }

        /// Metodo de tipo DataTable para llenar la tabla de productos, desde la base de datos.
        public DataTable llenarTabla()
        {
            /// Conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                DataTable dt = new DataTable();

                /// Consulta SQL para seleccionar los campos necesarios de la tabla productos.
                string sql = "SELECT * FROM productos";

                /// Adaptador de datos para ejecutar la consulta y llenar el DataTable.
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                da.Fill(dt);

                /// Cerrar la conexion y retornar el DataTable lleno.
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

        /// Metodo para insertar un nuevo producto en la base de datos.
        /// Recibe como parametros un objeto clsProductos con los datos del producto a insertar y el usuario que realiza la accion.
        public bool insertarProducto(clsProductos producto, string usuario)
        {
            /// Se crea una instancia de la conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                /// Abrir la conexion.
                cn.Open();

                ///Consulta SQL para asignar una variable de sesión del servidor
                string userSql = "SELECT @usuarioActual := @usuario;";

                /// Comando SQL para ejecutar la consulta.
                using (var cmdUser = new MySqlCommand(userSql, cn))
                {
                    cmdUser.Parameters.AddWithValue("@usuario", usuario);

                    try
                    {
                        cmdUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        /// Mostrar excepción real para depurar
                        //MessageBox.Show("Error al establecer variable de usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                /// comprobar que la variable quedó establecida.
                try
                {
                    /// Comando para verificar el valor de la variable de sesión.   
                    using (var cmdCheck = new MySqlCommand("SELECT @usuarioActual;", cn))
                    {
                        object val = cmdCheck.ExecuteScalar();
                        //MessageBox.Show("Valor @usuarioActual en servidor: " + (val ?? "NULL"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer @usuarioActual: " + ex.Message);
                    return false;
                }

                /// Consulta sql para insertar un producto
                string query = "INSERT INTO productos (nombre, descripcion, precio, stock, estado, foto) " +
                               "VALUES (@nombre, @descripcion, @precio, @stock, @estado, @foto)";

                /// Comando SQL para ejecutar la consulta.
                using (var cmd = new MySqlCommand(query, cn))
                {
                    /// Agregar los parametros necesarios para la insercion del producto.
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@stock", producto.stock);
                    cmd.Parameters.AddWithValue("@estado", "Activo");
                    cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = (producto.foto != null ? producto.foto : DBNull.Value);

                    /// Ejecutar el comando y verificar si se afecto alguna fila.
                    /// retornar true si se inserto correctamente, false en caso contrario.
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
                /// Cerrar la conexion.
                cn.Close();
            }
        }

        /// Metodo para eliminar un producto (marcar como descontinuado) en la base de datos.
        /// Los parametros son el id del producto a eliminar y el usuario que realiza la accion.
        public bool eliminarProducto(int idProducto, string usuario)
        {
            /// Conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                cn.Open();

                /// asignar la variable de sesión del servidor
                string userSql = "SELECT @usuarioActual := @usuario;";

                /// Comando SQL para ejecutar la consulta.
                using (var cmdUser = new MySqlCommand(userSql, cn))
                {
                    cmdUser.Parameters.AddWithValue("@usuario", usuario);

                    try
                    {
                        cmdUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        /// Mostrar excepción real para depurar
                        MessageBox.Show("Error al establecer variable de usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                /// comprobar que la variable quedó establecida
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

                /// realizar el borrado logico del producto.
                string query = "UPDATE productos SET estado = @estado, stock = @stock WHERE id_producto = @id_producto";

                /// Comando SQL para ejecutar la consulta.
                using (var cmd = new MySqlCommand(query, cn))
                {
                    /// Agregar los parametros necesarios para la modificacion del producto.
                    cmd.Parameters.AddWithValue("@estado", "Descontinuado");
                    cmd.Parameters.AddWithValue("@stock", 0);
                    cmd.Parameters.AddWithValue("@id_producto", idProducto);

                    /// Ejecutar el comando y verificar si se afecto alguna fila.
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
                /// Cerrar la conexion.
                cn.Close();
            }
        }

        /// Metodo para modificar un producto en la base de datos.
        /// Recibe como parametros un objeto clsProductos con los datos del producto a modificar y el usuario que realiza la accion.
        public bool modificarProducto(clsProductos producto, string usuario)
        {
            /// Se crea una instancia de la conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();
            try
            {
                /// Abrir la conexion.
                cn.Open();

                /// asignar variable de sesión del servidor
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
                        MessageBox.Show("Error al establecer variable de usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                /// comprobar que la variable quedó establecida
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
                }

                /// modificar el producto selecionado.
                string query = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, precio = @precio," +
                    "stock = @stock, estado = @estado, foto = @foto WHERE id_producto = @id_producto";

                /// Comando SQL para ejecutar la consulta.
                using (var cmd = new MySqlCommand(query, cn))
                {
                    /// Agregar los parametros necesarios para la modificacion del producto.
                    cmd.Parameters.AddWithValue("@id_producto", producto.id_Producto);
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@stock", producto.stock);
                    cmd.Parameters.AddWithValue("@estado", producto.estado);
                    cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = (producto.foto != null ? producto.foto : DBNull.Value);

                    /// Ejecutar el comando y verificar si se afecto alguna fila.
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
                /// Cerrar la conexion.
                cn.Close();
            }
        }

        /// Metodo para cargar los productos activos en un CheckedListBox.
        public void cargarProductoLista(CheckedListBox lista)
        {
            /// Conexion a la base de datos.
            MySqlConnection cn = Conexion.conexion();

            try
            {
                /// Abrir la conexion.
                cn.Open();

                /// Consulta SQL para seleccionar los productos activos.
                string query = "SELECT id_producto, nombre FROM productos WHERE estado = 'Activo'";

                /// crear el comando y ejecutar la consulta.
                MySqlCommand comando = new MySqlCommand(query, cn);
                MySqlDataReader reader = comando.ExecuteReader();
                
                    lista.Items.Clear();

                /// Leer los resultados y agregarlos al CheckedListBox.
                while (reader.Read())
                    {
                        ProductoItem p = new ProductoItem
                        {
                            IdProducto = reader.GetInt32("id_producto"),
                            Nombre = reader.GetString("nombre")
                        };

                        lista.Items.Add(p, false);
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar productos: " + e.Message);
            }
            finally
            {
                /// Cerrar la conexion.
                cn.Close();
            }
        }
    }
}
