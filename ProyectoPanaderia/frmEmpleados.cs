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


            /// Asignar "N" al campo de id empleado para indicar que es un nuevo empleado.
            txtIdEmpleado.Text = "N";
        }

        /// Constructor del formulario que recibe un objeto clsEmpleados como parametro, el cual se usa para modificar un empleado existente.
        public frmEmpleados(clsEmpleados empleado)
        {
            InitializeComponent();

            /// Configurar los ComboBox para que no permitan editar el texto directamente.
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            /// Asignar el objeto empleado recibido como parametro al objeto empleadoActual.
            empleadoActual = empleado;

            /// Llenar los campos del formulario con los datos del empleado a modificar.
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

        /// Evento click del boton guardar, que guarda o modifica un empleado dependiendo de si es un nuevo empleado o uno existente.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /// Validar que todos los campos esten completos.
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtHoras.Text == "" || txtSueldo.Text == "" || txtCorreo.Text == "" 
                || cboRol.Text == "" || cboEstado.Text == "" || txtContraseña.Text == "" || txtCofirmarContra.Text == "")
            {
                MessageBox.Show("Se deben completar todos los campos.");
                return;
            }
            /// Validar que las horas trabajadas esten entre 1 y 12.
            int horas = int.Parse(txtHoras.Text);
            if(horas < 1 || horas > 12)
            {
                MessageBox.Show("Las horas trabajadas deben estar entre 1 y 12.");
                return;
            }
            /// Validar que el numero de telefono tenga 10 digitos.
            int telefonoLength = txtTelefono.Text.Length;
            if(telefonoLength < 10 || telefonoLength > 10)
            {
                MessageBox.Show("El numero de telefono debe tener 10 digitos.");
                return;
            }
            /// Validar que el correo electronico tenga un formato valido.
            if (!validarCorreo())
            {
                return;
            }
            /// Validar que las contraseñas coincidan.
            if (txtContraseña.Text != txtCofirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            else
            {
                /// Crear un objeto clsEmpleados y asignar los valores de los campos del formulario a sus propiedades.
                clsEmpleados empleado = new clsEmpleados();

                /// Asignar los valores de los campos del formulario a las propiedades del objeto empleado.
                empleado.nombre = txtNombre.Text;
                empleado.usuario = txtUsuario.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.correo = txtCorreo.Text;
                empleado.rol = cboRol.Text;
                empleado.horas = int.Parse(txtHoras.Text);
                empleado.sueldo = float.Parse(txtSueldo.Text);
                empleado.estado = cboEstado.Text;
                empleado.contraseña = txtContraseña.Text;

                /// Verificar si es un nuevo empleado o uno existente para guardar o modificar respectivamente.
                /// Si es un nuevo empleado, el campo de id empleado es "N".
                if (txtIdEmpleado.Text == "N")
                {
                    /// objeto de la clase clsEmpleadosConsultas para insertar un nuevo empleado en la base de datos.
                    clsEmpleadosConsultas insertar = new clsEmpleadosConsultas();

                    try
                    {
                        /// Llamar al metodo insertarEmpleado para guardar el nuevo empleado en la base de datos.
                        /// Se envia como parametro el objeto empleado con los datos ingresados en el formulario.
                        insertar.insertarEmpleado(empleado);
                        MessageBox.Show("Empleado guardado exitosamente.");

                        /// Limpiar los campos del formulario y regresar al formulario de CRUD de empleados.
                        /// Se envia como parametro el empleadoActual para mantener la sesion iniciada.
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
                    /// Objeto de la clase clsEmpleadosConsultas para modificar un empleado existente en la base de datos.
                    clsEmpleadosConsultas modificar = new clsEmpleadosConsultas();

                    /// Asignar el id del empleado a modificar.
                    empleado.id_empleado = int.Parse(txtIdEmpleado.Text);

                    try
                    {
                        /// Llamar al metodo modificarEmpleado para actualizar los datos del empleado en la base de datos.
                        modificar.modificarEmpleado(empleado);
                        MessageBox.Show("Empleado modificado exitosamente.");

                        /// Limpiar los campos del formulario y regresar al formulario de CRUD de empleados.
                        /// Se envia como parametro el empleadoActual para mantener la sesion iniciada.
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

        /// Metodo para validar el formato del correo electronico usando expresiones regulares.
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

        /// Metodo para limpiar los campos del formulario.
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

        /// Evento click del boton regresar, que regresa al formulario de CRUD de empleados.
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            frmCrudEmpleados crudEmpleados = new frmCrudEmpleados(empleadoActual);
            this.Hide();
            crudEmpleados.ShowDialog();
            this.Close();
        }

        /// Eventos KeyPress para validar que en los campos de telefono y horas solo se ingresen numeros.
        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            /// Permite: borrar
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            /// Permite: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            /// Bloquea todos los demás caracteres
            e.Handled = true;
        }

        /// Evento KeyPress para validar que en el campo de horas solo se ingresen numeros.
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// Permite: borrar
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            /// Permite: números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            /// Permite un solo punto decimal
            if (e.KeyChar == '.')
            {
                if (!txtSueldo.Text.Contains("."))
                    return; 
            }

            /// Bloquea todo lo demás
            e.Handled = true;
        }

        /// Eventos click de los botones para mostrar u ocultar las contraseñas ingresadas.
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
