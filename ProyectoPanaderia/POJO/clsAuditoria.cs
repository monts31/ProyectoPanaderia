using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.POJO
{
    internal class clsAuditoria
    {
        public int id_Auditoria { get; set; }
        public int id_Empleado { get; set; }
        public string accion { get; set; }
        public int valor_Anterior { get; set; }
        public int valor_Nuevo { get; set; }
        public DateTime fecha { get; set; }
    }
}
