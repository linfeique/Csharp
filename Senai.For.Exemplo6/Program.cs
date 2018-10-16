using System;

namespace Senai.For.Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de números: ");
            int quantNumeros = int.Parse(Console.ReadLine());

            int[] arrayNumeros = new int[quantNumeros];

            for (int i = 0; i < quantNumeros; i++){
                System.Console.WriteLine("\nInforme o número: \n");
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }   

            Array.Sort(arrayNumeros);

            System.Console.WriteLine($"O menor número é: {arrayNumeros[0]}");
            System.Console.WriteLine($"O maior número é: {arrayNumeros[quantNumeros - 1]}");
        }
    }
}
