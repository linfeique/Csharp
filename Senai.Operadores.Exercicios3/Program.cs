using System;

namespace Senai.Operadores.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do produto 1: ");
            byte produto1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto 2: ");
            byte produto2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto 3: ");
            byte produto3 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto 4: ");
            byte produto4 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto 5: ");
            byte produto5 = Convert.ToByte(Console.ReadLine());

            int soma = produto1 + produto2 + produto3 + produto4 + produto5;
            int media = soma / 5;
            Console.WriteLine($"A média dos produtos é: { media }");
        }
    }
}
