using System;
using Senai.POO.Exercicios4.classes;

namespace Senai.POO.Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDeCredito cliente1 = new CartaoDeCredito();
            CartaoDeCredito cliente2 = new CartaoDeCredito();


            // Cliente 1
            Console.WriteLine("Informe o número do cartão do primeiro cliente: ");
            cliente1.NumCartao = Console.ReadLine();

            Console.WriteLine("Informe a data de validade do cartão do primeiro cliente: ");
            cliente1.DataDeValidade = Convert.ToDateTime(Console.ReadLine());


            // Cliente 2
            Console.WriteLine("Informe o número do cartão do segundo cliente: ");
            cliente2.NumCartao = Console.ReadLine();

            Console.WriteLine("Informe a data de validade do cartão do segundo cliente: ");
            cliente2.DataDeValidade = Convert.ToDateTime(Console.ReadLine());

            // Mostrar na tela
            Console.WriteLine("----------------------------");
            Console.WriteLine($"\nO número do cartão de crédito do primeiro cliente é: {cliente1.NumCartao}");
            Console.WriteLine($"\nA data de validade do cartão de crédito é: {cliente1.DataDeValidade}");
            Console.WriteLine("\n----------------------------");
            Console.WriteLine($"\nO número do cartão de crédito do segundo cliente é: {cliente2.NumCartao}");
            Console.WriteLine($"\nA data de validade do cartão de crédito é: {cliente2.DataDeValidade}\n");
        }
    }
}