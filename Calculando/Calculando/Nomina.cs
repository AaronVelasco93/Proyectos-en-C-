using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando
{
    public class Nomina
    {
        //variables
        private decimal pagopordia;

        //seters y geters
        public decimal PagoPorDia { get; set; }

        //declaracion de metodo para realizar el calculo

        public decimal PagoNomina(int diasLaborados, decimal pagoDia) {

            decimal salario = diasLaborados * pagoDia;
            return salario;
        }

    }
}
