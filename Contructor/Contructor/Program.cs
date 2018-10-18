using System;

namespace Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ventana calculadora = new ventana();
            //calculadora.Mostrar();

            Console.ReadKey();
        }
    }

    class ventana {
        private int ancho;
        private int altura;
        private string color;

        public ventana() {

            ancho = 15;
            altura = 20;
            color = "Rojo";

            Console.WriteLine("funciona");
        }
        public void Mostrar() {
            Console.WriteLine("la dimencion de la ventana es: "+ancho+" x "+altura+" y su color es: "+color);  
        }

        ~ventana() {
            System.Diagnostics.Trace.WriteLine("Se destruyeron lso recursos");
        }


    }
}
