using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.POJO
{
    public class clsDetallesOrden
    {
        public int id_Orden { get; set; }
        public int id_Producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_Total { get; set; }
    }
}
