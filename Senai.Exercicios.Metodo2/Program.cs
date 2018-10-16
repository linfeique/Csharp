using System;

namespace Senai.Exercicios.Metodo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O número que vôce digitou é {num}");
            incrementa(ref num);
            Console.WriteLine($"O número após ser incrementado é {num}");
        }

        static void incrementa(ref int valor)
        {
            valor++;
        }
    }
}
