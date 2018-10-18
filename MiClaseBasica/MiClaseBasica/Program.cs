using System;

namespace MiClaseBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo miVeiculo;
            miVeiculo = new Veiculo("Renolt",1325,"5236-v");

            //miVeiculo.marca = "Chevrolet";
            Console.WriteLine(miVeiculo.marca);
            
        }
    }
}
