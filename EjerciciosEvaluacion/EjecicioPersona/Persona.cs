using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecicioPersona
{
    //Clase persona con atributos Nombre, Edad, y Direccion.
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        //Constructor que inicializa los atributos
        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;

        }
        //Constructor sin parámetros que asigne valores predeterminados a los atributos
        public Persona()
        {
            Nombre = "Sin nombre";
            Edad = 0;
            Direccion = "Sin dirección";

        }
        //Metodo para mostrar la informacón de la persona
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Direccion: {Direccion}");
        }
        // Método asincrónico que simula una operación de lectura de datos
        public async Task LeerDatosAsync()
        {
            Console.WriteLine("Simulando la lectura de datos...");
            await Task.Delay(2000); // Simula un retardo de 2 segundos
            Console.WriteLine("Lectura de datos completada.");
        }
    }
}