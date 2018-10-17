using System;
using Senai.Exercicios.Classe.Array2.classes;

namespace Senai.Exercicios.Classe.Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Informacoes[] informacoes = new Informacoes[10];
            int resposta;

            for (int i = 0; i < 2; i++){
                        informacoes[i] = new Informacoes();

                        Console.WriteLine("Qual o nome do usuário: ");
                        informacoes[i].Nome = Console.ReadLine();
                        

                        Console.WriteLine("Qual o email do usuário: ");
                        informacoes[i].Email = Console.ReadLine();
                        bool Email =  informacoes[i].Nome.Contains("@");

                        Console.WriteLine("Qual a senha do usuário: ");
                        informacoes[i].Senha = Console.ReadLine();
            }

            Console.Clear();

            System.Console.WriteLine("--------- Menu de Acesso ---------");
            System.Console.WriteLine("1 - Acessar o sistemas");
            System.Console.WriteLine("2 - Cadastrar um usuário");
            System.Console.WriteLine("3 - Listar os usuários");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("\nQual você escolhe: ");
            resposta = int.Parse(Console.ReadLine());

            switch (resposta){
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("Informe o seu email: ");

                break;

                case 2:
                    
                break;

                case 3:

                break;

                default:
                    System.Console.WriteLine("Escolha uma alternativa!!!");
                break;
            }
        }

        static int VerificarEmail(retorno)
        {
            if (){
                
            }
        }
    }
}
