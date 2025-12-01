using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.Backend
{
    public class ProductoItem
    {
        /// Atributos de la clase ProductoItem
        /// que nos sirve para llenar el checkedlist con productos
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        
        public override string ToString()
        {
            return Nombre;
        }
    }
}
