using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using ProyectoPanaderia.Backend;
using ProyectoPanaderia.POJO;
using System;
using System.Collections;
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
    public partial class frmCrudProductos : Form
    {
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmCrudProductos()
        {
            InitializeComponent();
            cargarProductos();
        }

        public frmCrudProductos(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
            cargarProductos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmProductos insertar = new frmProductos(empleadoActual);
            this.Hide();
            insertar.ShowDialog();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto a actualizar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsProductos producto = new clsProductos();

            try
            {
                producto.id_Producto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                producto.nombre = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                producto.descripcion = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                producto.precio = float.Parse(dgvProductos.CurrentRow.Cells[3].Value.ToString());
                producto.stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells[4].Value);
                producto.estado = dgvProductos.CurrentRow.Cells[5].Value.ToString();

                // Abrir el formulario de edición
                frmProductos modificar = new frmProductos(empleadoActual, producto);
                this.Hide();
                modificar.ShowDialog();
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menu = new frmMenuAdmin(empleadoActual);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        public void cargarProductos()
        {
            clsProductosConsultas cons = new clsProductosConsultas();
            dgvProductos.DataSource = cons.llenarTabla();

            dgvProductos.AllowUserToDeleteRows = true;
            dgvProductos.ReadOnly = false;
            dgvProductos.AutoGenerateColumns = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsProductosConsultas eliminar = new clsProductosConsultas();
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

            DialogResult r = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (r == DialogResult.OK)
            {
                try
                {
                    //eliminar.eliminarProducto(idProducto);
                    MessageBox.Show("Producto eliminado correctamente");
                }
                catch
                {
                    MessageBox.Show("No se pudo eliminar el producto");
                }
                finally
                {
                    cargarProductos();
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }
    }
}
