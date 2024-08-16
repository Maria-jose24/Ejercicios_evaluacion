using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class AsyncAwait
    {
        // Método asincrónico que simula la lectura de datos con un retardo
        public static async Task SimularLecturaDatosAsync()
        {
            Console.WriteLine("Iniciando la operación de lectura de datos...");
            await Task.Delay(3000); // Simula una espera de 3 segundos
            Console.WriteLine("Operación de lectura de datos completada.");
        }

        // Método Main que utiliza async para poder llamar al método asincrónico
        static async Task Main(string[] args)
        {
            Console.WriteLine("Inicio de la aplicación...");

            // Llamada al método asincrónico
            await SimularLecturaDatosAsync();

            Console.WriteLine("Fin de la aplicación.");
        }
    }
}
