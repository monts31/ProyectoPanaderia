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
            frmEmpleados insertar = new frmEmpleados(empleadoActual);
            this.Hide();
            insertar.ShowDialog();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmEmpleados insertar = new frmEmpleados(empleadoActual);
            this.Hide();
            insertar.ShowDialog();
            this.Close();
        }

        public void cargarProductos()
        {
            clsEmpleadosConsultas cons = new clsEmpleadosConsultas();
            dgvEmpleados.DataSource = cons.llenarTabla();

            dgvEmpleados.AllowUserToDeleteRows = true;
            dgvEmpleados.ReadOnly = false;
        }
    }
}
