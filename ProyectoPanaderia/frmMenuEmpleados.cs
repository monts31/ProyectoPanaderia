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
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmMenuEmpleados()
        {
            InitializeComponent();
        }

        public frmMenuEmpleados(clsEmpleados empleados)
        {
            InitializeComponent();
            empleadoActual = empleados;
            lblEmpleado.Text = "Bienvenido: " + empleadoActual.nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas(empleadoActual);
            this.Hide();
            venta.ShowDialog();
            this.Close();
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
            frmReporteSencillo frm = new frmReporteSencillo(empleadoActual);
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
