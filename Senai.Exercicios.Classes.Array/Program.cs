using System;
using Senai.Exercicios.Classes.Array;

namespace Senai.Exercicios.Classes.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Programa de Cadastro ---------");
            Console.WriteLine("Quantos usuários você irá cadastrar: ");
            int QuantUser = int.Parse(Console.ReadLine());
            int i;
            Cadastro[] cadastros = new Cadastro[QuantUser];
            
            for (i = 0; i < QuantUser; i++){
                cadastros[i] = new Cadastro();

                Console.WriteLine("\nQual o nome do usuário: ");
                cadastros[i].Nome = Console.ReadLine();

                System.Console.WriteLine("Qual a idade do usuário: ");
                cadastros[i].Idade = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o endereço do usuário: ");
                cadastros[i].Endereco = Console.ReadLine();
            } 

            for (i = QuantUser - 1; i >= 0; i--){
                System.Console.WriteLine($"\n{QuantUser - i}º Cadastro");
                System.Console.WriteLine($"\nNome: {cadastros[i].Nome}");
                System.Console.WriteLine($"Idade: {cadastros[i].Idade}");
                System.Console.WriteLine($"Endereço: {cadastros[i].Endereco}");
            }
        }
    }
}
