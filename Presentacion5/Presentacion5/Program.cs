using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleado empleado;
            empleado = new clsEmpleado();

            empleado.Edad = 24;
            empleado.Nombre = "Aaron Velasco";
            empleado.SueldoDiario = 12.5m;

            decimal total;
            total = empleado.calculaSalario(30);
            Console.WriteLine($"su nombre es: {empleado.Nombre}");
            Console.WriteLine("El salario del empleado es:"+total);

        }
    }
}
