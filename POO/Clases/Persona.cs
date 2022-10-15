using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        public string Nombres{get; set;}
        public string Apellidos{get; set;}
        public DateTime FechaNacimiento{get; set;}
        public bool Sexo{get; set;}
        public UInt16 Edad { get; set; }
        public decimal Estatura { get; set; }

        public Persona() { }
        public Persona(string nombres, string apellidos, DateTime fechanacimiento, bool sexo, UInt16 edad, decimal estatura){
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechanacimiento;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Estatura = estatura;
        }

        public virtual string ObtenerNombreCompleto() {
            return this.Nombres + ' ' + this.Apellidos;
        }

        public void Limpiar() {
            this.Nombres = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Now;
            this.Estatura = 0;
            this.Sexo = false;
            this.Edad = 0;
        }


    }
}
