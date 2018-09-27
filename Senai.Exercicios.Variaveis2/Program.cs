using System;

namespace Senai.Exercicios.Variaveis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a base do seu número");
            int baise = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o expoente do seu número");
            int expoente = Convert.ToInt16(Console.ReadLine());

            double numero_total = Math.Pow(baise, expoente);
            Console.WriteLine($"O valor total da sua potenciaçao é: { numero_total }");
        }
    }
}
