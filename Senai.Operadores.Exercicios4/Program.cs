using System;

namespace Senai.Operadores.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de celcius: ");
            float celcius = float.Parse(Console.ReadLine());

            Console.WriteLine("A fórmula de fahrenheit é: F = (9 * C + 160) / 5");
            float fahrenheit = ((9 * celcius) + 160) / 5;

            Console.WriteLine($"O valor { celcius } em celcius é { fahrenheit } em fahrenheit");
        }
    }
}