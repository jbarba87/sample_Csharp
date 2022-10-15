using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Reservas
{
    public class Reverva
    {
        public UInt16 codReserva { get; set; }
        public UInt16 codVehiculo { get; set; }
        public DateTime fecha { get; set; }
        public string destino { get; set; }
        public UInt16 kilometros { get; set; }
        public UInt16 codEmpleado { get; set; }

        public Reverva() { }
        public Reverva(UInt16 codReserva, UInt16 codVehiculo, DateTime fecha, string destino, UInt16 kilometros, UInt16 codEmpleado)
        {
            this.codReserva = codReserva;
            this.codVehiculo = codVehiculo;
            this.fecha = fecha;
            this.destino = destino;
            this.kilometros = kilometros;
            this.codEmpleado = codEmpleado;
        }


    }


}
