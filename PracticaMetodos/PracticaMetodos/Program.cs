using System;

namespace PracticaMetodos
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int Valor1 = 7;
            double Valor2 = 5.2;
            double Valor3 = 8.3;


            Console.WriteLine(Suma(Valor1,Valor2));
           
        }

         static double Suma(int num1, double num2,double num3=0)
        {
            return num1+num2+num3;
        }

        static double Suma(int num1, double num2) {
            return num1 + num2;
        }
    }
}
