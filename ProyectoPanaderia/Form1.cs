using ProyectoPanaderia.POJO;
using System;
using System.Text;
using System.Windows.Forms;



namespace ProyectoPanaderia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsEmpleados empleado = new clsEmpleados();
            empleado.usuario = txtUsuario.Text.Trim();
            empleado.contraseña = txtContraseña.Text.Trim();

            Backend.clsLogin login = new Backend.clsLogin();
            try
            {
                if (login.IniciarSesion(empleado))
                {
                    MessageBox.Show("Bienvenido: "+empleado.nombre + empleado.rol);
                    if (empleado.rol == "Administrador")
                    {
                        frmMenuAdmin adminForm = new frmMenuAdmin(empleado);
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else if (empleado.rol == "Empleado")
                    {
                        frmMenuEmpleados empleadosform = new frmMenuEmpleados(empleado);
                        this.Hide();
                        empleadosform.ShowDialog();
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);

            }
        }
    }
}
