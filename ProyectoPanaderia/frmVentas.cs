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
using ProyectoPanaderia.Backend;

namespace ProyectoPanaderia
{
    public partial class frmVentas : Form
    {
        clsEmpleados empleadoActual = new clsEmpleados();

        public MostradoresProductos controller = new MostradoresProductos();
        public frmVentas()
        {
            InitializeComponent();

        }

        public frmVentas(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
        }

        public void cargarProductos()
        {
            // Lógica para cargar productos en el formulario de ventas
            clsProductosConsultas productosConsultas = new clsProductosConsultas();
            DataTable tabla = new DataTable();
            tabla = productosConsultas.obtenerProductos();
            foreach (DataRow fila in tabla.Rows)
            {
                MostradoresProductos productoControl = new MostradoresProductos();
                productoControl.CargarDatos(
                    Convert.ToInt32(fila["id_Producto"]),
                    fila["nombre"].ToString(),
                    Convert.ToDecimal(fila["precio"]),
                    fila["foto"] as byte[]
                );
                productoControl.Agregar += productoControl_Agregar;



                flowLayoutPanel1.Controls.Add(productoControl);
            }
        }

        public void productoControl_Agregar(object sender, EventArgs e)
        {
            MostradoresProductos producto = sender as MostradoresProductos;
            int cantidad = producto.obtenerPrecio();
            decimal subtotal = cantidad * producto.precioProducto;

            dataGridView1.Rows.Add(
                producto.idProducto,
                producto.nombreProducto,
                producto.precioProducto,
                cantidad,
                subtotal
            );
        }

        public void frmVentas_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clsOrdenes orden = new clsOrdenes();
            clsCompras compra = new clsCompras();
            orden.fecha = DateTime.Now;
            decimal total = 0;
            int idOrden = compra.registrarOrden(orden);

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                clsDetallesOrden detallesOrden = new clsDetallesOrden();

                total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menu = new frmMenuAdmin(empleadoActual);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
