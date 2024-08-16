using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecicioPersona
{
    // Clase Persona que representa a una persona con atributos como Nombre, Edad, y Direccion.
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Direccion = "";
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }
    }
}