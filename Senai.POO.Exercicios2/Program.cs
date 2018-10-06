using System;
using Senai.POO.Exercicios2.classes;

namespace Senai.POO.Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produtos p1 = new Produtos();
            Produtos p2 = new Produtos();
            Produtos p3 = new Produtos();

            #region p1
                Console.WriteLine("Informe o nome do produto 1: ");
                p1.nome = Console.ReadLine();

                Console.WriteLine("Informe o preço do produto 1: ");
                p1.preco = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do produto 1: ");
                p1.quantidade = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region p2
                Console.WriteLine("Informe o nome do produto 2: ");
                p2.nome = Console.ReadLine();

                Console.WriteLine("Informe o preço do produto 2: ");
                p2.preco = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do produto 2: ");
                p2.quantidade = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region p3
                Console.WriteLine("Informe o nome do produto 3: ");
                p3.nome = Console.ReadLine();

                Console.WriteLine("Informe o preço do produto 3: ");
                p3.preco = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do produto 3: ");
                p3.quantidade = Convert.ToInt32(Console.ReadLine());
            #endregion

            float soma = p1.preco + p2.preco + p3.preco;
            Console.WriteLine($"A soma dos produtos é R$ {soma},00");
            float media = soma / 3;
            Console.WriteLine($"A média dos produtos é R$ {media},00");
        }
    }
}
