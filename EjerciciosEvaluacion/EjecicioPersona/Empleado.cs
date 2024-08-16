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
            string nombre;
            int edad;
            string direccion;
            decimal salario;
            int diasTrabajados;

            // Validar el nombre para que solo permita letras
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del empleado:");
                nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre) || !NombreValido(nombre))
                {
                    Console.WriteLine("Nombre inválido. Solo se permiten letras.");
                }
                else
                {
                    break;
                }
            }

            // Validar la edad para que solo permita números enteros positivos
            while (true)
            {
                Console.WriteLine("Ingrese la edad del empleado:");
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Solo se permiten números enteros positivos.");
                }
            }

            Console.WriteLine("Ingrese la dirección del empleado:");
            direccion = Console.ReadLine();

            // Validar el salario para que sea un número decimal válido
            while (true)
            {
                Console.WriteLine("Ingrese el salario base del empleado:");
                if (decimal.TryParse(Console.ReadLine(), out salario) && salario >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Salario inválido. Solo se permiten números decimales positivos.");
                }
            }

            // Validar el número de días trabajados para que sea un número entero positivo
            while (true)
            {
                Console.WriteLine("Ingrese el número de días trabajados:");
                if (int.TryParse(Console.ReadLine(), out diasTrabajados) && diasTrabajados >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número de días inválido. Solo se permiten números enteros positivos.");
                }
            }

            Empleado empleado = new Empleado(nombre, edad, direccion, salario);

            Console.WriteLine("Calculando el salario...");
            await Task.Delay(5000); // Espera de 5 segundos

            empleado.MostrarInformacion(diasTrabajados);
        }

        // Método para validar que el nombre solo contenga letras
        static bool NombreValido(string nombre)
        {
            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}