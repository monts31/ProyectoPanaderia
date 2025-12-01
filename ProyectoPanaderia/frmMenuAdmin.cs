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
    public partial class frmMenuAdmin : Form
    {

        /// Objeto de tipo clsEmpleados para almacenar el empleado actual.
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmMenuAdmin(clsEmpleados empleado)
        {
            InitializeComponent();
            /// Asignar el empleado actual al empleado pasado como parametro.
            /// Colocar el nombre del empleado en la etiqueta de bienvenida.
            empleadoActual = empleado;
            lblEmpleado.Text = "Bienvenido: " + empleadoActual.nombre;
        }

        /// Evento click del boton productos, que abre el formulario de CRUD de productos.
        private void btnProductos_Click(object sender, EventArgs e)
        {
            /// Abrir el formulario de CRUD de productos, pasando el empleado actual como parametro.
            frmCrudProductos productos = new frmCrudProductos(empleadoActual);
            this.Hide();
            productos.ShowDialog();
            this.Close();
        }

        /// Evento click del boton detalles de orden, que abre el formulario de reporte sencillo.
        private void btnDetallesdeorden_Click(object sender, EventArgs e)
        {
            /// Abrir el formulario de reporte sencillo, pasando el empleado actual como parametro.
            frmReporteSencillo sencillo = new frmReporteSencillo(empleadoActual);
            this.Hide();
            sencillo.ShowDialog();
            this.Close();
        }

        /// Evento click del boton auditorias, que abre el formulario de auditorias.
        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            /// se envias el empleado actual para mantener la sesion activa
            frmAuditorias auditorias = new frmAuditorias(empleadoActual);
            this.Hide();
            auditorias.ShowDialog();
            this.Close();
        }

        /// Evento click del boton empleados, que abre el formulario de CRUD de empleados.
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            /// Abrir el formulario de CRUD de empleados, pasando el empleado actual como parametro.
            frmCrudEmpleados empleados = new frmCrudEmpleados(empleadoActual);
            this.Hide();
            empleados.ShowDialog();
            this.Close();
        }

        /// Evento click del boton ventas, que abre el formulario de ventas.
        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas(empleadoActual);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        /// Evento click del boton CRUD Empleados, que abre el formulario de CRUD de empleados.
        private void Crud_Empleados_Click(object sender, EventArgs e)
        {
            frmCrudEmpleados crudEmpleados = new frmCrudEmpleados(empleadoActual);
            this.Hide();
            crudEmpleados.ShowDialog();
            this.Close();
        }

        /// Evento click del boton cerrar sesion, que regresa al login.
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
