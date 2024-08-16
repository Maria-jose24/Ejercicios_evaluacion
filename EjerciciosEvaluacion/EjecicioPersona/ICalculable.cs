using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecicioPersona
{
    public interface ICalculable
    {
        // Método que deberá ser implementado en las clases que usen esta interfaz
        decimal CalcularSalario();
    }
}