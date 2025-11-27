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
        
        
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmMenuAdmin(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
            lblEmpleado.Text = "Bienvenido: " + empleadoActual.nombre;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmCrudProductos productos = new frmCrudProductos(empleadoActual);
            this.Hide();
            productos.ShowDialog();
            this.Close();
        }

        private void btnDetallesdeorden_Click(object sender, EventArgs e)
        {

        }

        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            frmAuditorias auditorias = new frmAuditorias(empleadoActual);
            this.Hide();
            auditorias.ShowDialog();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmCrudEmpleados empleados = new frmCrudEmpleados(empleadoActual);
            this.Hide();
            empleados.ShowDialog();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas(empleadoActual);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        private void Crud_Empleados_Click(object sender, EventArgs e)
        {
            frmCrudEmpleados crudEmpleados = new frmCrudEmpleados(empleadoActual);
            this.Hide();
            crudEmpleados.ShowDialog();
            this.Close();
        }
    }
}
