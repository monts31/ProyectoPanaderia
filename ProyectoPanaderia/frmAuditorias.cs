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
    public partial class frmAuditorias : Form
    {
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmAuditorias()
        {
            InitializeComponent();
        }

        public frmAuditorias(clsEmpleados empleados)
        {
            InitializeComponent();
            empleadoActual = empleados;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menu = new frmMenuAdmin(empleadoActual);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        public void llenarAuditorias()
        {
            Backend.clsAuditorias auditorias = new Backend.clsAuditorias();
            DataTable tablaAuditorias = auditorias.obtenerAuditoria();
            dataGridView1.DataSource = tablaAuditorias;

        }

        private void frmAuditorias_Load(object sender, EventArgs e)
        {
            llenarAuditorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteFecha reporte = new frmReporteFecha();
            this.Hide();
            reporte.ShowDialog();
            this.Close();
        }
    }
}
