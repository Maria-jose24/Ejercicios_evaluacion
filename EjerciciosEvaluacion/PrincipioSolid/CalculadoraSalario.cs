using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    // Clase abstracta CalculadoraSalario (Abierto/Cerrado)
    public abstract class CalculadoraSalario
    {
        public abstract double CalcularSalario(Empleado empleado);
    }

    // Implementación de CalculadoraSalario para salario básico
    public class CalculadoraSalarioBasico : CalculadoraSalario
    {
        public override double CalcularSalario(Empleado empleado)
        {
            return empleado.Salario;
        }
    }

    // Implementación de CalculadoraSalario para salario con bonificación
    public class CalculadoraSalarioBonificado : CalculadoraSalario
    {
        public double Bonificacion { get; set; }

        public CalculadoraSalarioBonificado(double bonificacion)
        {
            Bonificacion = bonificacion;
        }

        public override double CalcularSalario(Empleado empleado)
        {
            return empleado.Salario + Bonificacion;
        }
    }
}