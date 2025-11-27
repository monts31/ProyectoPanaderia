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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Solo se aceptan números");
                return;
            }
            if (textBox1.Text == "" || textBox1.Text=="0")
            {
                MessageBox.Show("Ingrese una cantidad valida");
                return;
            }
            if(int.Parse(textBox1.Text) > Stock)
            {
                MessageBox.Show("No hay suficiente stock disponible");
                return;
            }

            if (Agregar != null)
            {
                 Agregar(this, EventArgs.Empty);
            }

        }

        public int obtenerPrecio()
        {
            int c = 1;
            int.TryParse(textBox1.Text, out c);
            return c;

        }

        
    }
}
