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

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas();
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }
    }
}
