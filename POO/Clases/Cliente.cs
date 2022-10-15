using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Cliente : Persona{
        public string RUC { get; set;}
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }

        public Cliente() {
            
        }

        public int Antiguedad() {
            return DateTime.Now.Year - this.FechaIngreso.Year;
        }
    }

}
