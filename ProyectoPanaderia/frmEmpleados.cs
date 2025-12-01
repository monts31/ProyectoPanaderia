using ProyectoPanaderia.Backend;
using ProyectoPanaderia.POJO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderia
{
    public partial class frmEmpleados : Form
    {
        /// Objeto de tipo clsEmpleados para almacenar el empleado actual.
        clsEmpleados empleadoActual = new clsEmpleados();

        ///  Constructor por defecto del formulario, el cual se usa para insertar un nuevo empleado.
        public frmEmpleados()
        {
            InitializeComponent();
            /// Configurar los ComboBox para que no permitan editar el texto directamente.
            /// Se lleva a cabo para evitar errores de ingreso de datos.
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;


            /// Si se inserta un empleado, por logia debe de estar activo, por lo que el ComboBox de estado se deshabilita y se selecciona "Activo" por defecto.
            cboEstado.SelectedIndex = 0;
            cboEstado.Enabled = false;

            txtIdEmpleado.Text = "N";
        }

        public frmEmpleados(clsEmpleados empleado)
        {
            InitializeComponent();
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            empleadoActual = empleado;

            txtIdEmpleado.Text = empleadoActual.id_empleado.ToString();
            txtNombre.Text = empleadoActual.nombre;
            txtUsuario.Text = empleadoActual.usuario;
            txtTelefono.Text = empleadoActual.telefono;
            txtCorreo.Text = empleadoActual.correo;
            cboRol.Text = empleadoActual.rol;
            txtHoras.Text = empleadoActual.horas.ToString();
            txtSueldo.Text = empleadoActual.sueldo.ToString();
            cboEstado.Text = empleadoActual.estado;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtHoras.Text == "" || txtSueldo.Text == "" || txtCorreo.Text == "" 
                || cboRol.Text == "" || cboEstado.Text == "" || txtContraseña.Text == "" || txtCofirmarContra.Text == "")
            {
                MessageBox.Show("Se deben completar todos los campos.");
                return;
            }
            int horas = int.Parse(txtHoras.Text);
            if(horas < 1 || horas > 12)
            {
                MessageBox.Show("Las horas trabajadas deben estar entre 1 y 12.");
                return;
            }
            if (!validarCorreo())
            {
                return;
            }
            if(txtContraseña.Text != txtCofirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            else
            {
                clsEmpleados empleado = new clsEmpleados();

                empleado.nombre = txtNombre.Text;
                empleado.usuario = txtUsuario.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.correo = txtCorreo.Text;
                empleado.rol = cboRol.Text;
                empleado.horas = int.Parse(txtHoras.Text);
                empleado.sueldo = float.Parse(txtSueldo.Text);
                empleado.estado = cboEstado.Text;
                empleado.contraseña = txtContraseña.Text;

                if (txtIdEmpleado.Text == "N")
                {
                    empleado.contraseña = txtContraseña.Text;

                    //MessageBox.Show("Entre aqui");
                    clsEmpleadosConsultas insertar = new clsEmpleadosConsultas();

                    try
                    {
                        insertar.insertarEmpleado(empleado);
                        MessageBox.Show("Empleado guardado exitosamente.");

                        limpiar();
                        frmCrudEmpleados crud = new frmCrudEmpleados(empleadoActual);
                        this.Hide();
                        crud.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el empleado: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Entre a modificar");

                    clsEmpleadosConsultas modificar = new clsEmpleadosConsultas();

                    empleado.id_empleado = int.Parse(txtIdEmpleado.Text);

                    try
                    {
                        modificar.modificarEmpleado(empleado);
                        MessageBox.Show("Empleado modificado exitosamente.");

                        limpiar();
                        frmCrudEmpleados crud = new frmCrudEmpleados(empleadoActual);
                        this.Hide();
                        crud.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el empleado: " + ex.Message);
                    }
                }
            }
        }

        private bool validarCorreo()
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return false;
            }
            return true;
        }
        private void limpiar()
        {
            txtIdEmpleado.Text = "N";
            txtNombre.Clear();
            txtUsuario.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cboRol.SelectedIndex = -1;
            txtHoras.Clear();
            txtSueldo.Clear();
            cboEstado.SelectedIndex = -1;
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

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == false)
                txtContraseña.UseSystemPasswordChar = true;
            else
                txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            if (txtCofirmarContra.UseSystemPasswordChar == false)
                txtCofirmarContra.UseSystemPasswordChar = true;
            else
                txtCofirmarContra.UseSystemPasswordChar = false;
        }
    }
}
