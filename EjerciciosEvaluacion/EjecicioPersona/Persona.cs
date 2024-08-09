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
        class Program
        {
            static void Main(string[] args)
            {
                //Usando el constructor con parámetros
                Empleado empleado1 = new Empleado("Maria Jose", 18, "Carrera 13B Número 29-23 Las Palmitas Campoalegre", 2800.00m);
                empleado1.MostrarInformacion();

                //Método a la clase que muestre la información de la persona en la consola 
                Empleado empleado2 = new Empleado();
                empleado2.MostrarInformacion();
            }
        }
    }
}