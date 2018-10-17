using System;

namespace UsoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int minumero;
            int aleatorio = numero.Next(0, 100);
            int intentos = 0;
            Console.WriteLine("Introduce un numero entre 0 y 100");

            
            do{
                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("No mas introducido un valor numerico valido. se toma como numero introducido el 0");
                    minumero = 0;
                    Console.WriteLine(ex.Message);
                }
                
                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");
                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");
            } while (aleatorio != minumero) ;
                Console.WriteLine($"Correcto as nesecitado {intentos} intentos");
            Console.WriteLine("A partir de esta linea el programa continua");


        }
    }
}
