using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    // Interfaz IEmpleadoComun (Segregación de Interfaces)
    public interface IEmpleadoComun
    {
        string ObtenerInformacionBasica(Empleado empleado);
    }

    // Interfaz IBonificaciones
    public interface IBonificaciones
    {
        double ObtenerBonificaciones(Empleado empleado);
    }

    // Implementación de IEmpleadoComun
    public class EmpleadoComun : IEmpleadoComun
    {
        public string ObtenerInformacionBasica(Empleado empleado)
        {
            return $"Nombre: {empleado.Nombre}, Cargo: {empleado.Cargo}";
        }
    }

    // Implementación de IBonificaciones
    public class EmpleadoBonificado : IBonificaciones
    {
        public double ObtenerBonificaciones(Empleado empleado)
        {
            // Lógica de bonificaciones
            return empleado.Salario * 0.10; // Ejemplo: 10% de bonificación
        }
    }
}