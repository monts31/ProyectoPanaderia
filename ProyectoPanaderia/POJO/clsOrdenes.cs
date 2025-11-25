using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.POJO
{
    public class clsOrdenes
    {
       public int id_Orden { get; set; }
        public int id_Empleado { get; set; }
        public DateTime fecha { get; set; }
    }
}
