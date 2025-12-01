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
    public partial class frmCrudEmpleados : Form
    {
        /// Objeto de tipo clsEmpleados para almacenar el empleado actual.
        clsEmpleados empleadoActual = new clsEmpleados();

        public frmCrudEmpleados()
        {
            InitializeComponent();
        }

        public frmCrudEmpleados(clsEmpleados empleado)
        {
            InitializeComponent();
            /// Asignar el empleado actual al empleado pasado como parametro.
            /// Se carga la tabla de empleados.
            empleadoActual = empleado;
            cargarProductos();
        }

        /// Evento click del boton regresar, que regresa al menu principal de administrador.
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menu = new frmMenuAdmin(empleadoActual);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        /// Evento click del boton insertar, que abre el formulario para insertar un nuevo empleado.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmEmpleados insertar = new frmEmpleados();
            this.Hide();
            insertar.ShowDialog();
            this.Close();
        }

        /// Evento click del boton modificar, que abre el formulario para modificar un empleado seleccionado en la tabla.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            /// Verificar que se haya seleccionado una fila en la tabla.
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado a modificar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /// Crear un objeto clsEmpleados para obtener los datos del empleado seleccionado.
            clsEmpleados empleado = new clsEmpleados();

            try
            {
                /// Asignar los valores de la fila seleccionada a las propiedades del objeto empleado.
                
                empleado.id_empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                empleado.nombre = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                empleado.usuario = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                empleado.telefono = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                empleado.correo = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                empleado.rol = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                empleado.horas = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[6].Value);
                empleado.sueldo = float.Parse(dgvEmpleados.CurrentRow.Cells[7].Value.ToString());
                empleado.estado = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();

                /// Abrir el formulario de edición
                /// Como parametros se le pasa el objeto empleado con los datos cargados para modificar.
                frmEmpleados modificar = new frmEmpleados(empleado);
                this.Hide();
                modificar.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del empleado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// Metodo para cargar los productos en la tabla de empleados.
        public void cargarProductos()
        {
            clsEmpleadosConsultas cons = new clsEmpleadosConsultas();
            dgvEmpleados.DataSource = cons.llenarTabla();

            /// Configurar las propiedades del DataGridView para que no se puedan agregar o eliminar filas directamente.
            dgvEmpleados.AllowUserToDeleteRows = true;
            dgvEmpleados.ReadOnly = false;
        }

        /// Evento click del boton eliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /// Verificar que se haya seleccionado una fila en la tabla.
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto a actualizar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /// Crear un objeto clsEmpleadosConsultas para realizar el borrado logico del empleado
            /// Se obtiene el id del empleado seleccionado en la tabla.
            clsEmpleadosConsultas eliminar = new clsEmpleadosConsultas();
            empleadoActual.id_empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);

            /// Mostrar un mensaje de confirmacion antes de eliminar el empleado.
            DialogResult r = MessageBox.Show("¿Seguro que deseas eliminar al empleado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            /// Veridcar la respuesta del usuario.
            if (r == DialogResult.OK)
            {
                try
                {
                    /// Llamar al metodo eliminarEmpleado para realizar el borrado logico.
                    eliminar.eliminarEmpleado(empleadoActual);
                    MessageBox.Show("Empleado eliminado correctamente");
                }
                catch
                {
                    MessageBox.Show("No se pudo eliminar al empleado");
                }
                finally
                {
                    /// Recargar la tabla de empleados.
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
