using System;

namespace Senai.Exercicios.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float multi = valor1 * valor2;
            Console.WriteLine($"O produto dos dois valores é: { multi }");
        }
    }
}
