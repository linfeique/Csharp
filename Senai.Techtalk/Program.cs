using System;
using System.Collections.Generic;
using System.IO;
using Senai.Techtalk.Classes;

namespace Senai.Techtalk
{
    class Program
    {
        static Cadastro[] usuarios = new Cadastro[10];
        static int qtdCadastros = 0;
        static bool senha = false;
        static bool email = false;

        static void Main(string[] args)
        {

            StreamWriter writer = new StreamWriter(@"C:\Users\44846245837\Desktop\Csharp\Senai.Techtalk\teste.txt"); 
            StreamReader reader = new StreamReader(@"C:\Users\44846245837\Desktop\Csharp\Senai.Techtalk\teste.txt");


            usuarios[qtdCadastros] = new Cadastro();
            if (qtdCadastros < usuarios.Length)
            {
                do
                {
                    System.Console.WriteLine("Insira o nome do usuário a ser cadastrado: ");
                    usuarios[qtdCadastros].Nome = Console.ReadLine();
                    foreach (var item in usuarios)
                    {
                        if (item != null)
                        {
                            if (item.Nome == reader.ReadLine())
                            {
                                System.Console.WriteLine("Esse email já existe!!");
                            }
                            else
                            {
                                email = true;
                                break;
                            }
                        }
                    }
                } while (!email);

                do
                {
                    System.Console.WriteLine("Insira a senha do usuário a ser cadastrado: ");
                    usuarios[qtdCadastros].Senha = Console.ReadLine();
                    foreach (var item in usuarios)
                    {
                        if (item != null)
                        {
                            if (item.Senha == reader.ReadLine())
                            {
                                System.Console.WriteLine("Essa senha já existe!!");
                            }
                            else
                            {
                                senha = true;
                                break;
                            }
                        }
                    }
                } while (!senha);

                writer.WriteLine(usuarios[qtdCadastros].Nome +":"+ usuarios[qtdCadastros].Senha);
                qtdCadastros++;
            }
        }
    }
}
