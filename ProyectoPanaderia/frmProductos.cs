using ProyectoPanaderia.Backend;
using ProyectoPanaderia.POJO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Drawing.Imaging;

namespace ProyectoPanaderia
{
    public partial class frmProductos : Form
    {
        /// Crear el objeto empleadoActual para almacenar la información del empleado que está utilizando el formulario
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmProductos()
        {
            InitializeComponent();
        }

        /// Constructor que recibe un objeto clsEmpleados para registrar la acción en las auditorías
        /// Se utiliza este constructor para insertar un nuevo producto
        public frmProductos(clsEmpleados empleados)
        {
            InitializeComponent();
            /// Asignar el empleado recibido al objeto empleadoActual
            /// Se envía "N" en el campo de ID para indicar que es un nuevo producto
            /// Establecer el estado predeterminado en "Activo"
            empleadoActual = empleados;
            txtIdProducto.Text = "N";
            cboEstado.SelectedIndex = 0;
        }

        /// Constructor que se utiliza para modificar un producto existente
        /// Sus parámetros son el empleado actual y el producto a modificar
        public frmProductos(clsEmpleados empleados, clsProductos producto)
        {
            InitializeComponent();
            /// Configurar el ComboBox para que no permita edición directa
            /// Asignar el empleado recibido al objeto empleadoActual
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            empleadoActual = empleados;

            /// Cargar los datos del producto en los controles del formulario
            txtIdProducto.Text = producto.id_Producto.ToString();
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            txtPrecio.Text = producto.precio.ToString();

            /// Configurar el estado del producto en el ComboBox
            if (txtIdProducto.Text == "N")
            {
                /// Nuevo producto, establecer estado predeterminado que es "Activo"
                cboEstado.SelectedIndex = 0;
            }
            else
            {
                /// Producto existente, cargar estado desde el objeto producto
                cboEstado.Enabled = true;
                cboEstado.SelectedItem = producto.estado;
            }

            /// Cargar el stock y la imagen del producto
            txtStock.Text = producto.stock.ToString();
            /// Convertir el arreglo de bytes a imagen y asignarla al PictureBox
            pcbProducto.Image = clsConvertirImagen.BytesAImagen(producto.foto);

        }

        /// Evento click del botón Regresar, que vuelve al formulario de CRUD de productos.
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmCrudProductos crud = new frmCrudProductos(empleadoActual);
            this.Hide();
            crud.ShowDialog();
            this.Close();
        }

        /// Evento click del botón Guardar, que inserta o modifica el producto según corresponda.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /// Validar que todos los campos estén completos
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Se deben completar todos los campos.");
                return;
            }
            /// Validar que el precio sea un número válido mayor o igual a cero
            if (!float.TryParse(txtPrecio.Text.Trim(), out float precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor o igual a cero.");
                return;
            }
            else
            {
                /// Crear un objeto clsProductos y asignar los valores de los controles del formulario
                clsProductos producto = new clsProductos();

                /// Asignar los valores de los controles al objeto producto
                producto.nombre = txtNombre.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.precio = float.Parse(txtPrecio.Text.Trim());
                producto.stock = int.Parse(txtStock.Text.Trim());
                producto.estado = cboEstado.SelectedItem.ToString();

                /// Revisar si se ha seleccionado una imagen y convertirla a un arreglo de bytes
                if (pcbProducto.Image != null)
                {
                    producto.foto = clsConvertirImagen.ImagenABytes(pcbProducto.Image);
                }
                else
                {
                    producto.foto = null;
                }

                /// Verificar si se trata de una inserción o una modificación según el valor del campo txtIdProducto
                if (txtIdProducto.Text == "N")
                {
                    /// Inserción de un nuevo producto
                    clsProductosConsultas insertar = new clsProductosConsultas();

                    try
                    {
                        /// Llamar al método para insertar el producto, pasando el empleadoActual para auditoría
                        /// Se envia el objeto producto con los datos a insertar
                        insertar.insertarProducto(producto, empleadoActual.usuario);
                        MessageBox.Show("Producto guardado exitosamente.");

                        /// Limpiar los campos del formulario y regresar al CRUD de productos
                        limpiar();
                        frmCrudProductos crud = new frmCrudProductos(empleadoActual);
                        this.Hide();
                        crud.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el producto: " + ex.Message);
                    }
                }
                else
                {
                    /// Modificación de un producto existente
                    /// se asigna el ID del producto al objeto producto
                    clsProductosConsultas modificar = new clsProductosConsultas();
                    producto.id_Producto = int.Parse(txtIdProducto.Text);

                    try
                    {
                        /// Llamar al método para modificar el producto, pasando el empleadoActual para auditoría
                        /// También se envia el objeto producto con los datos a modificar
                        modificar.modificarProducto(producto, empleadoActual.usuario);
                        MessageBox.Show("Producto modificado exitosamente.");

                        /// Limpiar los campos del formulario y regresar al CRUD de productos
                        limpiar();
                        frmCrudProductos crud = new frmCrudProductos(empleadoActual);
                        this.Hide();
                        crud.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el producto: " + ex.Message);
                    }
                }
            }
        }

        /// Método para limpiar los campos del formulario
        public void limpiar()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        /// Validaciones para los campos de precio y stock
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// Permite: borrar 
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            /// Permite: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            /// Permite un solo punto decimal
            if (e.KeyChar == '.')
            {
                if (!txtPrecio.Text.Contains("."))
                    return; 
            }

            /// Bloquea todo lo demás
            e.Handled = true;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// Permite: borrar 
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            /// Permite: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            /// Bloquea todo lo demás
            e.Handled = true;
        }

        /// Evento click del botón para seleccionar una imagen del producto
        private void btnImagen_Click(object sender, EventArgs e)
        {
            /// Abrir un cuadro de diálogo para seleccionar una imagen
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg;*.bmp";

            /// Cargar la imagen seleccionada en el PictureBox
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    /// Usar un bloque using para asegurar que el archivo se cierre correctamente después de cargar la imagen
                    using (var temp = System.Drawing.Image.FromFile(ofd.FileName))
                    {
                        /// Asignar la imagen al PictureBox
                        pcbProducto.Image = new Bitmap(temp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void grbProducto_Enter(object sender, EventArgs e)
        {

        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
