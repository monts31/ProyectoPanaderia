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
        clsEmpleados empleado = new clsEmpleados();
        public frmMenuAdmin()
        {
            InitializeComponent();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            this.Hide();
            productos.ShowDialog();
            this.Close();
        }

        private void btnDetallesdeorden_Click(object sender, EventArgs e)
        {

        }

        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            frmAuditorias auditorias = new frmAuditorias();
            this.Hide();
            auditorias.ShowDialog();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmCrudEmpleados empleados = new frmCrudEmpleados();
            this.Hide();
            empleados.ShowDialog();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas();
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }

        private void Crud_Empleados_Click(object sender, EventArgs e)
        {
            frmCrudEmpleados crudEmpleados = new frmCrudEmpleados();
            this.Hide();
            crudEmpleados.ShowDialog();
            this.Close();
        }
    }
}
