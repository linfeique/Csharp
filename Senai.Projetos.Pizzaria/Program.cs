using System;
using Senai.Projetos.Pizzaria.Classes;

namespace Projeto.Pizzaria.Classes
{
    class Program
    {
        static int qtdCadastros = 0;
        static int qtdProdutos = 0;
        static bool arroba = false;
        static bool senha = false;
        static Cadastro[] usuarios = new Cadastro[10];
        static Produtos[] produtos = new Produtos[10];
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                MenuLogin();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Inserir();
                        break;

                    case 2:
                        EfetuarLogin();
                        break;

                    case 3:
                        Listar();
                        break;

                    case 0:

                        break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuLogin()
        {
            System.Console.WriteLine("Menu de Opções");
            System.Console.WriteLine("1 - Cadastrar Usuários");
            System.Console.WriteLine("2 - Login");
            System.Console.WriteLine("3 - Listar Usuários");
            System.Console.WriteLine("0 - Sair");
        }
        static void Inserir()
        {
            Console.Clear();
            usuarios[qtdCadastros] = new Cadastro();
            if (qtdCadastros < usuarios.Length)
            {

                System.Console.WriteLine("Insira o nome do usuário a ser cadastrado: ");
                usuarios[qtdCadastros].Nome = Console.ReadLine();

                usuarios[qtdCadastros].DataDeCriacao = DateTime.Now;

                do
                {
                    System.Console.WriteLine("Insira o e-mail do usuário a ser cadastrado: ");
                    usuarios[qtdCadastros].Email = Console.ReadLine();

                    if (usuarios[qtdCadastros].Email.Contains("@") && usuarios[qtdCadastros].Email.Contains("."))
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Email Inválido");
                    }
                } while (!arroba);

                do
                {
                    System.Console.WriteLine("Insira a senha do usuário a ser cadastrado: ");
                    usuarios[qtdCadastros].Senha = Console.ReadLine();

                    if (usuarios[qtdCadastros].Senha.Length >= 6)
                    {
                        System.Console.WriteLine("Cadastro Efetuado com Sucesso!");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Senha Inválida");
                    }
                } while (!senha);

                usuarios[qtdCadastros].Id = qtdCadastros + 1;
                qtdCadastros++;
            }

        }

        static void EfetuarLogin()
        {
            Console.Clear();
            string email_login;
            string senha_login;

            do
            {
                System.Console.WriteLine("Insira seu email: ");
                email_login = Console.ReadLine();

                if (email_login.Contains("@") && email_login.Contains("."))
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Email Inválido");
                }
            } while (!arroba);

            do
            {
                System.Console.WriteLine("Insira a senha: ");
                senha_login = Console.ReadLine();

                if (senha_login.Length >= 6)
                {
                    MenuPizzaria();
                    break;
                }
                else
                {
                    System.Console.WriteLine("Senha Inválida");
                }
            } while (!senha);


            bool encontrado = false;

            foreach (Cadastro login in usuarios)
            {
                if (login != null)
                {
                    if (email_login == login.Email && senha_login == login.Senha)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {

                System.Console.WriteLine("Email não cadastrado!!!");
                System.Console.WriteLine("Você quer cadastrar um novo usuário? [S/N]");
                string resposta = Console.ReadLine();
                switch (resposta.ToUpper())
                {
                    case "S":
                        Inserir();
                        break;
                    case "N":
                        break;
                    default:
                        System.Console.WriteLine("Opção não encontrada");
                        break;
                }

            }
        }

        static void Listar()
        {
            Console.Clear();
            System.Console.WriteLine("Seus usuário são: \n");

            bool user_encontrado = false;

            foreach (Cadastro item in usuarios)
            {
                if (item != null)
                {
                    int i = 0;

                    System.Console.WriteLine($"{i + 1}º Cadastro");
                    System.Console.WriteLine($"Nome: {item.Nome}");
                    System.Console.WriteLine($"E-mail: {item.Email}");
                    System.Console.WriteLine($"ID: {item.Id}");
                    System.Console.WriteLine($"Data de criação: {item.DataDeCriacao}");
                    user_encontrado = true;

                    i++;

                }
            }

            if (!user_encontrado)
            {
                System.Console.WriteLine("Não existe usuário cadastrado");
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void MenuPizzaria()
        {
            System.Console.WriteLine("Menu de Opções");
            System.Console.WriteLine("1 - Cadastrar Produto");
            System.Console.WriteLine("2 - Listar Produto");
            System.Console.WriteLine("3 - Exibir Total");
            System.Console.WriteLine("0 - Sair");

            int resposta_pizzaria = int.Parse(Console.ReadLine());

            switch (resposta_pizzaria)
            {
                case 1:
                    CadastrarProduto();
                break;

                case 2:
                    ListarProdutos();
                break;

                case 3:

                break;

                case 0:

                break;

                default:
                    System.Console.WriteLine("Essa opção é inexistente");
                break;
            }
        }

        static void CadastrarProduto()
        {
            Console.Clear();
            produtos[qtdProdutos] = new Produtos();

            produtos[qtdProdutos].DataDeCriacao = DateTime.Now;

            System.Console.WriteLine("Informe qual o nome do produto: ");
            produtos[qtdProdutos].Nome = Console.ReadLine();

            System.Console.WriteLine("Informe a descrição do produto: ");
            produtos[qtdProdutos].Descricao = Console.ReadLine();

            System.Console.WriteLine("Informe o preço do produto: ");
            produtos[qtdProdutos].Preço = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe entre [0 - 1] (pizza e bebida, respectivamente)");
            int resposta_categoria = int.Parse(Console.ReadLine());
            switch (resposta_categoria)
            {
                case 1:
                    produtos[qtdProdutos].Categoria = "pizza";
                break;

                case 2:
                    produtos[qtdProdutos].Categoria = "bebida";
                break;

                default:
                    System.Console.WriteLine("Essa opção não existe!!");
                break;
            }

            usuarios[qtdProdutos].Id = qtdProdutos + 1;
            qtdProdutos++;
        }

        static void ListarProdutos()
        {
            bool produto_encontrado = false;

            System.Console.WriteLine("Qual produto você quer mostrar: ");
            int produto_id = int.Parse(Console.ReadLine());

            
        }
    }
}