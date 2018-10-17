using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    public class clsEmpleado
    {

        //contructor
        public clsEmpleado() {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }
        public string Nombre;
        public decimal SueldoDiario;
        public int Edad;

        //metodo
        public decimal calculaSalario(int NumeroDias) {

            return SueldoDiario * NumeroDias;

        }
    }
}
