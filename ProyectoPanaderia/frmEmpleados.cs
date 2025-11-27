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
    public partial class frmEmpleados : Form
    {
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public frmEmpleados(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            frmCrudEmpleados crudEmpleados = new frmCrudEmpleados(empleadoActual);
            this.Hide();
            crudEmpleados.ShowDialog();
            this.Close();
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Permitir: borrar (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Bloquear todo lo demás
            e.Handled = true;
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir: borrar (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permitir un solo punto decimal
            if (e.KeyChar == '.')
            {
                if (!txtSueldo.Text.Contains("."))
                    return; // permitir agregar un punto
            }

            // Bloquear todo lo demás
            e.Handled = true;
        }
    }
}
