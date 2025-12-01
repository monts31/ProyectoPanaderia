using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderia.POJO
{
    /// Clase POJO para representar un empleado en el sistema de la panaderia.
    public class clsEmpleados
    {
        /// Atributos de la clase clsEmpleados
        /// getters y setters de cada atributo
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string rol { get; set; }
        public int horas { get; set; }
        public float sueldo { get; set; }
        public string estado { get; set; }
        public DateTime fecha_Contrato { get; set; }
    }
}
