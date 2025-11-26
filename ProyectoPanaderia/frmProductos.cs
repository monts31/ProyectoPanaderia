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
            txtIdEmpleado.Text = empleadoActual.id_Empleado.ToString();
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
                producto.nombre = txtNombre.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.precio = float.Parse(txtPrecio.Text.Trim());
                producto.stock = int.Parse(txtStock.Text.Trim());

                try
                {
                    clsProductosConsultas guardar = new clsProductosConsultas();
                    guardar.insertarProducto(producto);
                    MessageBox.Show("Producto guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
            }
        }
    }
}
