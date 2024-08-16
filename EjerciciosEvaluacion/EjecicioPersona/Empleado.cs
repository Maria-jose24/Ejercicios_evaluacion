using System;

namespace EjecicioPersona
{
    // Clase Empleado que hereda de Persona e implementa la interfaz ICalculable
    public class Empleado : Persona, ICalculable
    {
        public decimal Salario { get; set; }

        public Empleado(string nombre, int edad, string direccion, decimal salario)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
        }

        public Empleado() : base()
        {
            Salario = 0.0m;
        }

        public decimal CalcularSalario(int diasTrabajados)
        {
            return (Salario / 30) * diasTrabajados;
        }

        public new void MostrarInformacion(int diasTrabajados)
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario por {diasTrabajados} días trabajados: {CalcularSalario(diasTrabajados)}");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del empleado:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la dirección del empleado:");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el salario base del empleado:");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de días trabajados:");
            int diasTrabajados = int.Parse(Console.ReadLine());

            Empleado empleado = new Empleado(nombre, edad, direccion, salario);

            Console.WriteLine("Calculando el salario...");
            await Task.Delay(5000); // Espera de 5 segundos

            empleado.MostrarInformacion(diasTrabajados);
        }
    }
}