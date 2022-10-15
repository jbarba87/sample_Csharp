using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Reservas
{
    public class Vehiculo{
        public UInt16 codVehiculo { get; set; }
        public string Descripcion { get; set; }
        public Vehiculo() { }
        public Vehiculo(UInt16 codVehiculo, string Descripcion)
        {
            this.codVehiculo = codVehiculo;
            this.Descripcion = Descripcion;
        }


    }
}
