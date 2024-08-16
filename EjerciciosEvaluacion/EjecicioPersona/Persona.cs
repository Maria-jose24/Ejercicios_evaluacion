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
            Nombre = "";
            Edad = 0;
            Direccion = "";

        }
        //Metodo para mostrar la informacón de la persona
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Direccion: {Direccion}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Maria", 18, "Campoalegre", 1300000.0m);
            Console.WriteLine("Información del empleado 1:");
            empleado1.MostrarInformacion(15);//dias trabajados

            Console.WriteLine();

            Empleado empleado2 = new Empleado();
            Console.WriteLine("Información del empleado 2:");
            empleado2.MostrarInformacion(0);
        }
    }
}