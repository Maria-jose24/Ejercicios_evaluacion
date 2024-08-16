using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecicioPersona
{
    // Definición de la interfaz ICalculable
    // Una interfaz es un contrato que obliga a las clases que la implementan
    // a definir los métodos especificados dentro de ella.
    public interface ICalculable
    {
        // Este método debe ser implementado por cualquier clase que herede de ICalculable.
        // Toma un parámetro entero (diasTrabajados) que representa los días que la persona trabajó.
        // Devuelve un valor decimal que representa el salario calculado en función de los días trabajados.
        decimal CalcularSalario(int diasTrabajados);
    }
}
