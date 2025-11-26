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
            frmProductos producto = new frmProductos(empleadoActual);
            this.Hide();
            producto.ShowDialog();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

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
            dgvProductos.DataSource = cons.obtenerProductos();

            dgvProductos.AllowUserToDeleteRows = true;
            dgvProductos.ReadOnly = false;
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
                    eliminar.eliminarProducto(idProducto);
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
