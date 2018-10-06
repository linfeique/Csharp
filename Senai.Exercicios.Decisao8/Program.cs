using System;

namespace Senai.Exercicios.Decisao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a quantidade de maçãs que você vai comprar");
            int NumMaca = Convert.ToInt32(Console.ReadLine());

            if (NumMaca <= 6){
                Console.WriteLine($"Você comprou {NumMaca} maçãs, então pagará R$ 0,30");
                Console.WriteLine($"Você pagará um total de R$ {NumMaca * 0.30}");
            } else {
                Console.WriteLine($"Você comprou {NumMaca} maçãs, então pagará R$ 0,25");
                Console.WriteLine($"Você pagará um total de R$ {NumMaca * 0.25}");
            }
        }
    }
}
