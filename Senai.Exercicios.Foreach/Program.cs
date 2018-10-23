using System;
using Senai.Exercicios.Foreach.Classes;

namespace Senai.Exercicios.Foreach {
    class Program {
        static Usuario[] arrayUsuarios;
        static int contador = 0;

        static void Main (string[] args) {
            System.Console.WriteLine ("Informe a quantidade de usuários: ");
            int quantNumeros = int.Parse (Console.ReadLine ());

            // Instanciando o array
            arrayUsuarios = new Usuario[quantNumeros];

            int opcao = 0;

            do {
                MontarMenu ();
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        CadastrarUsuario ();
                        break;

                    case 2:
                        ListarUsuarios ();
                        break;

                    case 3:
                        AcessarSistema ();
                        break;

                    default:
                        System.Console.WriteLine ("Opção Inválida");
                        break;
                }
            } while (opcao != 0);
        }

        static void MontarMenu () {
            System.Console.WriteLine ("--------- Menu de Opção ---------");
            System.Console.WriteLine ("1 - Cadastrar");
            System.Console.WriteLine ("2 - Listar");
            System.Console.WriteLine ("3 - Acessar Sistema");
            System.Console.WriteLine ("0 - Sair");
            System.Console.WriteLine ("---------------------------------");
            System.Console.WriteLine ("\nEscolha a opção: ");
        }

        static void CadastrarUsuario () {
            arrayUsuarios[contador] = new Usuario ();
            bool emailValido = false;
            string email;

            Console.Clear ();
            #region Nome
            System.Console.WriteLine ("Informe seu nome: ");
            arrayUsuarios[contador].Nome = Console.ReadLine ();
            #endregion

            #region Email
            do {
                System.Console.WriteLine ("Informe seu email: ");
                email = Console.ReadLine ();

                if (email.Contains ("@") == true) {
                    emailValido = true;
                    arrayUsuarios[contador].Email = email;
                    System.Console.WriteLine ("Email Válido");
                    break;
                } else {
                    System.Console.WriteLine ("Email Inválido");
                }

            } while (!emailValido); // Verifica se o email é válido
            #endregion

            #region Senha
            bool senhaValida = false;
            string senha;

            do {
                System.Console.WriteLine ("Informe sua senha: ");
                senha = Console.ReadLine ();

                if (senha.Length >= 4) {
                    arrayUsuarios[contador].Senha = senha;
                    break;
                } else {
                    System.Console.WriteLine ("Senha Inválida");
                }
            } while (!senhaValida);
            #endregion

            Console.Clear ();
            System.Console.WriteLine ("Usuário Cadastrado!!!");
            contador++;
        }

        static void ListarUsuarios () {
            Console.Clear ();
            foreach (Usuario item in arrayUsuarios) {
                if (item != null) {
                    System.Console.WriteLine ($"{item.Nome} - {item.Email}");
                }
            }
        }

        static void AcessarSistema () {
            Console.Clear ();

            bool encontrado = false;

            do {
                Console.Clear ();
                System.Console.WriteLine ("Informe seu email: ");
                string emailVerificar = Console.ReadLine ();

                System.Console.WriteLine ("Informe sua senha: ");
                string senhaVerificar = Console.ReadLine ();

                foreach (Usuario item in arrayUsuarios) {

                    if (item != null) {
                        if (emailVerificar == item.Email && senhaVerificar == item.Senha) {
                            System.Console.WriteLine ("Sistema Acessado");
                            encontrado = true;
                            break;
                        }
                    }
                }
                if (!encontrado) {
                    System.Console.WriteLine ("Email ou senha incorretos");
                }
            } while (!encontrado);

        }
    }
}