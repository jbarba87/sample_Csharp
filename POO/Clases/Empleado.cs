using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Empleado : Persona {
    
        public string DNI { get; set;}
        public string Cargo { get; set; }
        public Decimal Sueldo { get; set; }

        public DateTime FechaContrato { get; set; }

        public Empleado() { }
        public Empleado(string dni, string nombres, string apellidos, DateTime fechanacimiento, string cargo, DateTime fechacontrato) {
            this.DNI = dni;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechanacimiento;
            this.Cargo = cargo;
            this.FechaContrato = FechaContrato;
        }

        public int TiempoServicio() {
            return DateTime.Now.Year - FechaContrato.Year;
        }

        public override string ObtenerNombreCompleto()
        {
            return this.Apellidos + ", " + this.Nombres;
        }
        public decimal CalculaSueldo(string cargo) {
            decimal sueldo = 0;
            switch (cargo) { 
                case "Gerente": sueldo = 5000; break;
                case "Jefe": sueldo = 3500; break;
                case "Supervisor": sueldo = 2500; break;
                case "Empleado": sueldo = 5000; break;
                default: break;
            }
            return sueldo;
        }

        public decimal CalculaBonificacion(string Cargo) {
            decimal bonificacion = 0;
            if (Cargo == "Gerente")
            {
                bonificacion = 1000;
            }
            else if (Cargo == "Jefe")
            {
                bonificacion = 800;
            }
            else if (Cargo == "Supervisor")
            {
                bonificacion = 600;
            }
            else if (Cargo == "Empleado")
            {
                bonificacion = 400;
            }

            return bonificacion;
        }

        public decimal CalculaDescuento(decimal sueldo)
        {

            decimal dscto = 0;
            if (sueldo > 2500)
            {
                dscto = sueldo * 0.1m;
            }
            else
            {
                dscto = sueldo * 0.05m;
            }
            return dscto;

        }

        public decimal CalculaNeto(decimal sueldo, decimal bonificacion, decimal descuento) {
            return sueldo + bonificacion - descuento;

        }

    }


}
