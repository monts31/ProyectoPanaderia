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
    public partial class frmMenuEmpleados : Form
    {
        /// Crear el objeto empleadoActual para almacenar la información del empleado que está utilizando el formulario
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmMenuEmpleados()
        {
            InitializeComponent();
        }

        public frmMenuEmpleados(clsEmpleados empleados)
        {
            InitializeComponent();
            /// Asignar el empleado recibido al objeto empleadoActual
            /// colocar el nombre del empleado en la etiqueta lblEmpleado
            empleadoActual = empleados;
            lblEmpleado.Text = "Bienvenido: " + empleadoActual.nombre;
        }

        /// Evento click del botón Ventas, que abre el formulario de ventas.
        private void button1_Click(object sender, EventArgs e)
        {
            /// Crear una instancia del formulario de ventas y pasar el empleadoActual
            frmVentas venta = new frmVentas(empleadoActual);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        /// Evento click del botón Productos, que abre el CRUD de productos.
        private void btnProductos_Click(object sender, EventArgs e)
        {
            /// Crear una instancia del formulario CRUD de productos y pasar el empleadoActual para las auditorías
            frmCrudProductos productos = new frmCrudProductos(empleadoActual);
            this.Hide();
            productos.ShowDialog();
            this.Close();
        }

        /// Evento click del botón Detalles de Orden, que abre el formulario de reporte sencillo.
        private void btnDetallesdeorden_Click(object sender, EventArgs e)
        {
            frmReporteSencillo frm = new frmReporteSencillo(empleadoActual);
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        /// Evento click del botón Cerrar Sesión, que regresa al formulario de inicio de sesión.
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
