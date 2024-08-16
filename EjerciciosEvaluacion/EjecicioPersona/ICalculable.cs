using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EjecicioPersona
{
    // Definición de la interfaz ICalculable
    public interface ICalculable
    {
        // Método que debe ser implementado por las clases que implementan esta interfaz.
        decimal CalcularSalario(int diasTrabajados);
    }
}
