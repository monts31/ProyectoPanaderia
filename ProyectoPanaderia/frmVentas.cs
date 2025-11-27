using ProyectoPanaderia.Backend;
using ProyectoPanaderia.POJO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderia
{
    public partial class frmVentas : Form
    {
        clsEmpleados empleadoActual = new clsEmpleados();

        public MostradoresProductos controller = new MostradoresProductos();
        

        public frmVentas(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
            label1.Text = "Empleado: " + empleadoActual.id_Empleado;
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

            int index = dataGridView1.Rows.Add(
                producto.idProducto,
                producto.nombreProducto,
                producto.precioProducto,
                cantidad,
                subtotal

            );
            dataGridView1.Rows[index].Cells["Accion"].Value = Properties.recursos.eliminar;
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
            orden.id_Empleado = empleadoActual.id_Empleado;
            MessageBox.Show("Registrando orden..."+empleadoActual.id_Empleado);
            decimal total = 0;
            int idOrden = compra.registrarOrden(orden, dataGridView1);

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
            }
            if(idOrden > 0)
            {
                MessageBox.Show("Orden registrada con éxito. ID de Orden: " + idOrden + "\nTotal: $" + total.ToString("F2"));
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Error al registrar la orden.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menu = new frmMenuAdmin(empleadoActual);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Accion"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Remover de la compra?","Confirmar eliminación",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
