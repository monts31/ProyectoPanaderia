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
    public partial class MostradoresProductos : UserControl
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioProducto { get; set; }
        public int Stock { get; set; }

        public event EventHandler Agregar;
        public MostradoresProductos()
        {
            InitializeComponent();
        }
        //este metodo carga los datos del producto en el mostrador
        public void CargarDatos(int id, string nombre, decimal precio, int stock, byte[] foto)
        {
            idProducto = id;
            nombreProducto = nombre;
            precioProducto = precio;
            lblNombre.Text = nombre;
            Stock = stock;

            if (foto != null)
            {
                using (var ms = new MemoryStream(foto))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.BackColor = Color.Green; // Color predeterminado si no hay imagen
            }
        }

        //este metodo verifica que el texto ingresado sea un numero valido y no mayor al stock disponible
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Solo se aceptan números válidos");
                textBox1.Clear();
                return;
            }
            if (!int.TryParse(textBox1.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida");
                textBox1.Clear();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero");
                textBox1.Clear();
                return;
            }

            if (cantidad > Stock)
            {
                MessageBox.Show("No hay suficiente stock disponible");
                textBox1.Clear();
                return;
            }

            if (Agregar != null)
            {
                 Agregar(this, EventArgs.Empty);
                textBox1.Clear();
            }

        }

        //este metodo obtiene el precio del producto que se selecciono
        public int obtenerPrecio()
        {
            int c = 1;
            int.TryParse(textBox1.Text, out c);
            return c;

        }

        
    }
}
