using System;

namespace Senai.Exercicios.While2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor inicial: ");
            long ValorI = long.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor final: ");
            long ValorF = long.Parse(Console.ReadLine());

            while (ValorI <= ValorF){
                Console.WriteLine($"{ValorI}");
                ValorI++;
            }
        }
    }
}
