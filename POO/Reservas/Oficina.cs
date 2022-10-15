using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Reservas
{
    public class Oficina{

        public UInt16 codOficina { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }

        public Oficina() { }
        public Oficina(UInt16 codOficina, string direccion, string localidad, string provincia)
        {
            this.codOficina = codOficina;
            this.direccion = direccion;
            this.localidad = localidad;
            this.provincia = provincia;
        }

    }
}
