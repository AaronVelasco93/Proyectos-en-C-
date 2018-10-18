using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNomina
{
    public class Empleado
    {
        //declaracion de variables
        private string nombre;
        private string identificacion;
        private decimal asignacionDia;

        //metodos seter y geter de nombre
        public string Nombre { get; set; }

        //metodo seter y geter de identificacion
        public string Identificacion { get; set; }
        
        //metodos geter y seter de asginacion
        public string AsignacionDia { get; set; }

    }
}
