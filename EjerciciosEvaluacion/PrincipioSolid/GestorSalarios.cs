using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    // Clase GestorSalarios (Inversión de Dependencias)
    public class GestorSalarios
    {
        private readonly CalculadoraSalario _calculadoraSalario;
        private readonly InformacionEmpleado _informacionEmpleado;

        public GestorSalarios(CalculadoraSalario calculadoraSalario, InformacionEmpleado informacionEmpleado)
        {
            _calculadoraSalario = calculadoraSalario;
            _informacionEmpleado = informacionEmpleado;
        }

        public void MostrarSalario(Empleado empleado)
        {
            double salario = _calculadoraSalario.CalcularSalario(empleado);
            string infoEmpleado = _informacionEmpleado.ObtenerInformacion(empleado);
            Console.WriteLine($"{infoEmpleado}, Salario: {salario}");
        }
    }

    // Programa principal dentro de la clase GestorSalarios
    public class Programa
    {
        public static void Main()
        {
            // Crear empleados
            Empleado empleado1 = new Empleado("Juan Pérez", "Desarrollador", 3000);
            Empleado empleado2 = new Empleado("Ana García", "Diseñadora", 2500);

            // Configurar calculadoras y gestores
            CalculadoraSalario calculadoraBasica = new CalculadoraSalarioBasico();
            CalculadoraSalario calculadoraBonificada = new CalculadoraSalarioBonificado(500);
            InformacionEmpleado infoDetallada = new InformacionEmpleadoDetallada();

            GestorSalarios gestorBasico = new GestorSalarios(calculadoraBasica, infoDetallada);
            GestorSalarios gestorBonificado = new GestorSalarios(calculadoraBonificada, infoDetallada);

            // Mostrar salarios
            gestorBasico.MostrarSalario(empleado1);
            gestorBonificado.MostrarSalario(empleado2);
        }
    }
}