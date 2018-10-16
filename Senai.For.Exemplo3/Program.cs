using System;

namespace Senai.For.Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 100; i >= 0; i--){
                num += 2;
                Console.WriteLine($"Número: {num}");
            }
        }
    }
}