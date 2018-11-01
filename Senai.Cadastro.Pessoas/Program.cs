using System;
using System.IO;
using Senai.Cadastro.Pessoas.ViewsControlles;

namespace Senai.Cadastro.Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioView = new UsuarioViewController();

            usuarioView.Menu();
            int resposta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("");
            
            switch (resposta)
            {
                case 1:
                    usuarioView.Cadastrar();
                break;
                
                case 2:
                    usuarioView.Logar();
                break;

                case 3:
                    usuarioView.Listar();
                break;

                default:
                    System.Console.WriteLine("Opção inválida");
                break;
            }
        }
    }
}
