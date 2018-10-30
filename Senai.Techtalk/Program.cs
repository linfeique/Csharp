using System;
using System.IO;

namespace Senai.Techtalk {
    class Program {

        static string leitura2;
        static void Main (string[] args) {
            int resposta = 0;

            System.Console.WriteLine ("------ Bem-vindo ------");

            if (File.Exists ("teste.txt")) {
                using (StreamReader ler2 = new StreamReader ("teste.txt", true)) {
                    leitura2 = ler2.ReadLine ();
                    do {
                        System.Console.WriteLine ("1- Cadastrar usuário");
                        System.Console.WriteLine ("2- Efetuar login");
                        System.Console.WriteLine ("0- Sair");
                        resposta = int.Parse (Console.ReadLine ());

                        switch (resposta) {

                            case 1:
                                #region cadastro
                                using (StreamWriter escrever = new StreamWriter ("teste.txt", true)) {
                                    Console.WriteLine ("Qual o nome do usuário a ser cadastrado: ");
                                    string nome = Console.ReadLine ();

                                    if (leitura2.Contains (nome)) {
                                        System.Console.WriteLine ("Usuário já cadastrado");
                                        break;
                                    } else {
                                        escrever.Write (nome + ":");
                                    }

                                    Console.WriteLine ($"Qual a senha do {nome}:");
                                    string senha = Console.ReadLine ();
                                    escrever.WriteLine (senha);
                                }
                                #endregion
                                break;

                            case 2:
                                string leitura;

                                #region  
                                using (StreamReader ler = new StreamReader ("teste.txt", true)) {
                                    if (File.Exists ("teste.txt")) {
                                        leitura = ler.ReadLine ();
                                        Console.WriteLine ("Qual o nome do usuário: ");
                                        string nome_login = Console.ReadLine ();

                                        if (leitura.Contains (nome_login)) {
                                            Console.WriteLine ($"Qual a senha do {nome_login}");
                                            string senha_login = Console.ReadLine ();
                                            if (leitura.Contains (senha_login)) {
                                                System.Console.WriteLine ("Bem vindo ao sistema");
                                                break;
                                            } else {
                                                System.Console.WriteLine ("Senha incorreta");
                                            }
                                        } else {
                                            System.Console.WriteLine ("Email incorreto");
                                        }
                                    }
                                }
                                #endregion
                                break;

                            case 0:

                                break;

                            default:
                                System.Console.WriteLine ("Opção inválida");
                                break;
                        }
                    } while (resposta != 0);
                }
            } else {
                using (StreamWriter escrever = new StreamWriter ("teste.txt", true)) {
                    do {
                        System.Console.WriteLine ("1- Cadastrar usuário");
                        System.Console.WriteLine ("2- Efetuar login");
                        System.Console.WriteLine ("0- Sair");
                        resposta = int.Parse (Console.ReadLine ());

                        switch (resposta) {

                            case 1:
                                #region cadastroS
                                    Console.WriteLine ("Qual o nome do usuário a ser cadastrado: ");
                                    string nome = Console.ReadLine ();

                                    if (leitura2.Contains (nome)) {
                                        System.Console.WriteLine ("Usuário já cadastrado");
                                        break;
                                    } else {
                                        escrever.Write (nome + ":");
                                    }

                                    Console.WriteLine ($"Qual a senha do {nome}:");
                                    string senha = Console.ReadLine ();
                                    escrever.WriteLine (senha);
                                #endregion
                                break;

                            case 2:
                                string leitura;

                                #region  
                                using (StreamReader ler = new StreamReader ("teste.txt", true)) {
                                    if (File.Exists ("teste.txt")) {
                                        leitura = ler.ReadLine ();
                                        Console.WriteLine ("Qual o nome do usuário: ");
                                        string nome_login = Console.ReadLine ();

                                        if (leitura.Contains (nome_login)) {
                                            Console.WriteLine ($"Qual a senha do {nome_login}");
                                            string senha_login = Console.ReadLine ();
                                            if (leitura.Contains (senha_login)) {
                                                System.Console.WriteLine ("Bem vindo ao sistema");
                                                break;
                                            } else {
                                                System.Console.WriteLine ("Senha incorreta");
                                            }
                                        } else {
                                            System.Console.WriteLine ("Email incorreto");
                                        }
                                    }
                                }
                                #endregion
                                break;

                            case 0:

                                break;

                            default:
                                System.Console.WriteLine ("Opção inválida");
                                break;
                        }
                    } while (resposta != 0);
                }
            }
        }
    }
}