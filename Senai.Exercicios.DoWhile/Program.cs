using System;

namespace Senai.Exercicios.DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando;

            do{
                Console.WriteLine("Insira seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira seu email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Insira seu telefone: ");
                string telefone = Console.ReadLine();

                Console.WriteLine($"\nNome: {nome}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Telefone: {telefone}");

                Console.WriteLine("\nDeseja realizar mais um cadastro? [SIM/NÃO]");
                comando = Console.ReadLine();
            } while(comando.ToUpper() == "SIM");
        }
    }
}
