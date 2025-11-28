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
        clsEmpleados empleadoActual = new clsEmpleados();

        public frmCrudEmpleados()
        {
            InitializeComponent();
        }

        public frmCrudEmpleados(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
            cargarProductos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menu = new frmMenuAdmin(empleadoActual);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmEmpleados insertar = new frmEmpleados();
            this.Hide();
            insertar.ShowDialog();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado a modificar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsEmpleados empleado = new clsEmpleados();

            try
            {
                empleado.id_empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                empleado.nombre = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                empleado.usuario = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                empleado.telefono = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                empleado.correo = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                empleado.rol = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                empleado.horas = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[6].Value);
                empleado.sueldo = float.Parse(dgvEmpleados.CurrentRow.Cells[7].Value.ToString());
                empleado.estado = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();

                // Abrir el formulario de edición
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

        public void cargarProductos()
        {
            clsEmpleadosConsultas cons = new clsEmpleadosConsultas();
            dgvEmpleados.DataSource = cons.llenarTabla();

            dgvEmpleados.AllowUserToDeleteRows = true;
            dgvEmpleados.ReadOnly = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto a actualizar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsEmpleadosConsultas eliminar = new clsEmpleadosConsultas();
            empleadoActual.id_empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);

            DialogResult r = MessageBox.Show("¿Seguro que deseas eliminar al empleado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (r == DialogResult.OK)
            {
                try
                {
                    eliminar.eliminarEmpleado(empleadoActual);
                    MessageBox.Show("Empleado eliminado correctamente");
                }
                catch
                {
                    MessageBox.Show("No se pudo eliminar al empleado");
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
