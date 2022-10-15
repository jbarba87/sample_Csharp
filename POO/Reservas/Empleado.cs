using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Reservas
{
    public class Empleado{

        public UInt16 codEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public UInt16 salario { get; set; }
        public UInt16 codOficina { get; set; }
        public DateTime fecha { get; set; }

        public Empleado() { }
        public Empleado(UInt16 codEmpleado, string nombre, string apellido, UInt16 salario, UInt16 codOficina, DateTime fecha)
        {
            this.codEmpleado = codEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
            this.codOficina = codOficina;
            this.fecha = fecha;
        }


    }
}
