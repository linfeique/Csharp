using System;

namespace Senai.For.Exemplo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de cadastros: ");
            int quantCadastros = int.Parse(Console.ReadLine());

            string[,] usuarios = new string[quantCadastros, 3];

            for (int i = 0; i < quantCadastros; i++){
                System.Console.WriteLine("Informe o seu nome: ");
                usuarios[i, 0] = Console.ReadLine();

                System.Console.WriteLine("Informe o seu Cpf: ");
                usuarios[i, 1] = Console.ReadLine();

                System.Console.WriteLine("Informe o seu telefone: ");
                usuarios[i, 2] = Console.ReadLine();
            }

            for (int i = 0; i < quantCadastros; i++){
                System.Console.WriteLine($"\n{usuarios[i, 0]} - {usuarios[i, 1]} - {usuarios[i, 2]}");
            }
        }
    }
}
