using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    // Clase Empleado (Responsabilidad Única)
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string cargo, double salario)
        {
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
        }
    }
}