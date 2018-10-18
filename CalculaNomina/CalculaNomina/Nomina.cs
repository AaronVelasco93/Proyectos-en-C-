using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNomina
{
    public class Nomina
    {
        //declaracion de vaiables
        private int diasLaborados;

        //metodo seter y geter  de DiasLaborales
        public int DiasLaborados { get; set; }

        //Metodo para calcular la nomina
        //metodo para calcular la el salario
        public decimal CalcularNomina(int diasLaborados, decimal valordia)
        {

            decimal totalSalario = diasLaborados * valordia;

            return totalSalario;
        }
    }
}
