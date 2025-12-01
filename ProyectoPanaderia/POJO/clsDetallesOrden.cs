using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.POJO
{
    /// Clase POJO para representar los detalles de orden en el sistema de la panaderia.
    public class clsDetallesOrden
    {
        /// Atributos de la clase clsDetallesOrden
        /// getters y setters de cada atributo
        public int id_Orden { get; set; }
        public int id_Producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_Total { get; set; }
    }
}
