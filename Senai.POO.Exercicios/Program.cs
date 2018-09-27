using System;
using Senai.POO.Exercicios.Classes;

namespace Senai.POO.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Informe o nome da pessoa 1");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da pessoa 1");
            pessoa.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa 1");
            pessoa.peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O nome da pessoa é {pessoa.Nome}");
            Console.WriteLine($"O peso da pessoa é {pessoa.peso}");
            Console.WriteLine($"A altura da pessoa é {pessoa.altura}");
            Console.WriteLine($"o imc dessa pessoa é {pessoa.peso / Math.Pow(pessoa.altura, 2)}");

            Console.WriteLine("Informe o nome da pessoa 2");
            pessoa.Nome = Console.ReadLine();

            
        }
    }
}
