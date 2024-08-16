using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    // Clase abstracta InformacionEmpleado (Sustitución de Liskov)
    public abstract class InformacionEmpleado
    {
        public abstract string ObtenerInformacion(Empleado empleado);
    }

    // Implementación concreta de InformacionEmpleado
    public class InformacionEmpleadoDetallada : InformacionEmpleado
    {
        public override string ObtenerInformacion(Empleado empleado)
        {
            return $"Nombre: {empleado.Nombre}, Cargo: {empleado.Cargo}, Salario: {empleado.Salario}";
        }
    }
}
