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
    public partial class frmProductos : Form
    {
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmProductos()
        {
            InitializeComponent();
        }

        public frmProductos(clsEmpleados empleados)
        {
            InitializeComponent();
            empleadoActual = empleados;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmCrudProductos crud = new frmCrudProductos(empleadoActual);
            this.Hide();
            crud.ShowDialog();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
