using System;
using Senai.Projetos.Pizzaria.Classes;

namespace Projeto.Pizzaria.Classes {
    class Program {
        static int qtdCadastros = 0;
        static bool arroba = false;
        static bool senha = false;
        static Cadastro[] usuarios = new Cadastro[10];
        static void Main (string[] args) {
            int opcao = 0;
            do {
                Console.Clear ();
                MenuLogin ();
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        Inserir ();
                        break;

                    case 2:
                        EfetuarLogin ();
                        break;

                    case 0:

                        break;

                    default:
                        System.Console.WriteLine ("Opção Inválida");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuLogin () {
            System.Console.WriteLine ("Menu de Opções");
            System.Console.WriteLine ("1 - Cadastrar Usuários");
            System.Console.WriteLine ("2 - Login");
            System.Console.WriteLine ("3 - Listar Usuários");
            System.Console.WriteLine ("0 - Sair");
        }
        static void Inserir () {
            Console.Clear ();
            usuarios[qtdCadastros] = new Cadastro ();
            if (qtdCadastros < usuarios.Length) {

                System.Console.WriteLine ("Insira o nome do usuário a ser cadastrado: ");
                usuarios[qtdCadastros].Nome = Console.ReadLine ();

                do {
                    System.Console.WriteLine ("Insira o e-mail do usuário a ser cadastrado: ");
                    usuarios[qtdCadastros].Email = Console.ReadLine ();

                    if (usuarios[qtdCadastros].Email.Contains ("@") && usuarios[qtdCadastros].Email.Contains (".")) {
                        break;
                    } else {
                        System.Console.WriteLine ("Email Inválido");
                    }
                } while (!arroba);

                do {
                    System.Console.WriteLine ("Insira a senha do usuário a ser cadastrado: ");
                    usuarios[qtdCadastros].Senha = Console.ReadLine ();

                    if (usuarios[qtdCadastros].Senha.Length >= 6) {
                        System.Console.WriteLine ("Cadastro Efetuado com Sucesso!");
                        break;
                    } else {
                        System.Console.WriteLine ("Senha Inválida");
                    }
                } while (!senha);

                usuarios[qtdCadastros].Id = qtdCadastros + 1;
                qtdCadastros++;
            }

        }

        static void EfetuarLogin () {
            Console.Clear ();
            string email_login;

            do {
                System.Console.WriteLine ("Insira seu email: ");
                email_login = Console.ReadLine ();

                if (email_login.Contains ("@") && email_login.Contains (".")) {
                    break;
                } else {
                    System.Console.WriteLine ("Email Inválido");
                }
            } while (!arroba);

            foreach (Cadastro login in usuarios) {
                if (login == null) { }
                if (email_login == login.Email) {
                    break;
                } else {
                    System.Console.WriteLine ("Email não cadastrado!!!");
                    System.Console.WriteLine ("Você quer cadastrar um novo usuário? [S/N]");
                    string resposta = Console.ReadLine ();
                    switch (resposta) {
                        case "S":
                            Inserir ();
                        break;
                        case "s":
                            Inserir ();
                        break;

                        case "N":

                        break;
                        case "n":

                        break;
                        default:
                            System.Console.WriteLine ("Opção não encontrada");
                        break;
                    }
                }
            }
        }
    }
}