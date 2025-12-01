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
        /// Crear el objeto empleadoActual para almacenar la información del empleado que está utilizando el formulario
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmCrudProductos()
        {
            InitializeComponent();
            cargarProductos();
        }

        public frmCrudProductos(clsEmpleados empleado)
        {
            InitializeComponent();
            /// Asignar el empleado recibido al objeto empleadoActual
            /// Cargar los productos en el DataGridView
            empleadoActual = empleado;
            cargarProductos();
        }

        /// Evento click del botón Insertar, que abre el formulario de productos a insertar.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            /// Abrir el formulario de inserción
            /// Se envía el empleadoActual para registrar la acción en las auditorías
            frmProductos insertar = new frmProductos(empleadoActual);
            this.Hide();
            insertar.ShowDialog();
            this.Close();
        }

        /// Evento click del botón Modificar, que abre el formulario de productos a modificar.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            /// Verificar que se haya seleccionado un producto a modificar.
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto a actualizar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /// Crear un objeto clsProductos para almacenar los datos del producto seleccionado.
            clsProductos producto = new clsProductos();

            try
            {
                /// Cargar los datos del producto seleccionado en el objeto producto.
                
                producto.id_Producto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                producto.nombre = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                producto.descripcion = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                producto.precio = float.Parse(dgvProductos.CurrentRow.Cells[3].Value.ToString());
                producto.stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells[4].Value);
                producto.estado = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                producto.foto = dgvProductos.CurrentRow.Cells[6].Value as byte[];

                /// Abrir el formulario de edición
                /// Envia como parametros el empleadoActual (para registrar en la tabla de auditorias) y el producto a modificar.
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

        /// Evento click del botón Regresar, que vuelve al menú correspondiente según el rol del empleadoActual.
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (empleadoActual.rol == "Administrador")
            {
                frmMenuAdmin adminForm = new frmMenuAdmin(empleadoActual);
                this.Hide();
                adminForm.ShowDialog();
                this.Close();
            }
            else if (empleadoActual.rol == "Empleado")
            {
                frmMenuEmpleados empleadosform = new frmMenuEmpleados(empleadoActual);
                this.Hide();
                empleadosform.ShowDialog();
                this.Close();
            }
        }

        /// Método para cargar los productos en el DataGridView.
        public void cargarProductos()
        {
            clsProductosConsultas cons = new clsProductosConsultas();
            dgvProductos.DataSource = cons.llenarTabla();

            /// Configurar el DataGridView para permitir la selección completa de filas y la edición directa.
            dgvProductos.AllowUserToDeleteRows = true;
            dgvProductos.ReadOnly = false;
            dgvProductos.AutoGenerateColumns = true;
        }

        /// Evento click del botón Eliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /// Se crea un objeto de la clase clsProductosConsultas, para acceder al backend.
            /// Se obtiene el id del producto seleccionado en el DataGridView.
            clsProductosConsultas eliminar = new clsProductosConsultas();
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

            /// Se muestra un cuadro de diálogo para confirmar la eliminación del producto.
            DialogResult r = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            /// Se verifica la respuesta del usuario.
            if (r == DialogResult.OK)
            {
                try
                {
                    /// Se llama al método eliminarProducto de la clase clsProductosConsultas.
                    /// Los parámetros son el id del producto y el usuario del empleadoActual para registrar la acción en las auditorías.
                    eliminar.eliminarProducto(idProducto, empleadoActual.usuario);
                    MessageBox.Show("Producto eliminado correctamente");
                }
                catch
                {
                    MessageBox.Show("No se pudo eliminar el producto");
                }
                finally
                {
                    /// Se recarga la lista de productos en el DataGridView.
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
