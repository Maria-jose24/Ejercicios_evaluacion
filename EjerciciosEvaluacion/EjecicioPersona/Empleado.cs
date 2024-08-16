using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecicioPersona
{
    //Clase Empleado que herede de Persona e incluya un
    //atributo adicional Salario. Sobreescribe el método
    //para mostrar la información, incluyendo el salario
    public class Empleado : Persona, ICalculable

    {
        //Atributo adicional Salario
        public decimal Salario { get; set; }

        public Empleado(string nombre, int edad, string direccion, decimal salario)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
        }

        public Empleado() : base()
        {
            //M indica que es un decimal
            Salario = 0.0m;
        }

        // Implementación del método CalcularSalario de la interfaz ICalculable
        public decimal CalcularSalario()
        {
            return Salario;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario:C}");
        }
    }
}