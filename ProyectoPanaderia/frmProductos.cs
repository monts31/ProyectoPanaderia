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
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmProductos()
        {
            InitializeComponent();
        }

        public frmProductos(clsEmpleados empleados)
        {
            InitializeComponent();
            empleadoActual = empleados;
            txtIdProducto.Text = empleadoActual.id_Empleado.ToString();
        }

        public frmProductos(clsEmpleados empleados, clsProductos producto)
        {
            InitializeComponent();
            empleadoActual = empleados;

            txtIdProducto.Text = producto.id_Producto.ToString();
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmCrudProductos crud = new frmCrudProductos(empleadoActual);
            this.Hide();
            crud.ShowDialog();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Se deben completar todos los campos.");
                return;
            }
            else
            {
                clsProductos producto = new clsProductos();
                producto.id_Producto = int.Parse(txtIdProducto.Text);
                producto.nombre = txtNombre.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.precio = float.Parse(txtPrecio.Text.Trim());
                producto.stock = int.Parse(txtStock.Text.Trim());

                try
                {
                    clsProductosConsultas guardar = new clsProductosConsultas();
                    guardar.modificarProducto(producto);
                    MessageBox.Show("Producto guardado exitosamente.");

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

        public void limpiar()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir: borrar (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permitir un solo punto decimal
            if (e.KeyChar == '.')
            {
                if (!txtPrecio.Text.Contains("."))
                    return; // permitir agregar un punto
            }

            // Bloquear todo lo demás
            e.Handled = true;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir: borrar (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Bloquear todo lo demás
            e.Handled = true;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcbProducto.Image = new Bitmap(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
    }
}
