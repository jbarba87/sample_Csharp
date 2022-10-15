using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Venta
    {
        public String Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Servicio { get; set; }
        public UInt16 Cantidad { get; set; }
        public Decimal Total { get; set; }
        public Decimal Descuento { get; set; }
        public Decimal Neto { get; set; }

        public decimal CalculaDescuento(UInt16 cantidad, decimal Total) {
            decimal descuento = 0;
            if (cantidad >= 10) {
                descuento = Total * 0.05m;
            }
            return descuento;
        }
        public decimal CalculaNeto(decimal total, decimal descuento) {
            return total - descuento;
        }
    }




}
