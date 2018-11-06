using System;
using System.Collections.Generic;
using System.IO;
using Senai.Cadastro.Pessoas.Models;

namespace Senai.Cadastro.Pessoas.ViewsControlles
{
    public class UsuarioViewController
    {
        int contador = 1;

        public void Menu(){
            System.Console.WriteLine("--------- Bem-Vindo ---------");
            System.Console.WriteLine("1 - Cadastrar");
            System.Console.WriteLine("2 - Logar");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("-----------------------------");

            System.Console.WriteLine("\nEscolha uma opção: ");
        }

        public void MenuFinanceiro(){
            System.Console.WriteLine("--------- Bem-Vindo ao Menu Financeiro ---------");
            System.Console.WriteLine("1- Cadastrar Transação");
            System.Console.WriteLine("2- Extrato de transações total");
            System.Console.WriteLine("3- Gerar Relatórios");
            System.Console.WriteLine("0- Sair");
        }

        public bool Verificacao_Email(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;
            } else{
                return false;
            }
        }

        public bool Verificacao_Senha(string senha){
            if(senha.Length >= 6){
                return true;
            } else{
                return false;
            }
        }

        public void Cadastrar(){
            string email;
            string senha;
            DateTime dataNascimento;
            bool senha_certa = false;
            bool email_certo = false;

            #region View
                System.Console.WriteLine("Informe o seu nome: ");
                string nome = Console.ReadLine();
                
                do{
                    System.Console.WriteLine("Informe o seu email: ");
                    email = Console.ReadLine();

                    if(Verificacao_Email(email) == true){
                        email_certo = true;
                        break;
                    } else{
                        System.Console.WriteLine("Email inválido");
                    }
                } while(!email_certo);
                
                do{
                    System.Console.WriteLine("Informe sua senha: ");
                    senha = Console.ReadLine();

                    if(Verificacao_Senha(senha) == true){
                        senha_certa = true;
                        break;
                    } else{
                        System.Console.WriteLine("Senha Inválida");
                    }
                } while(!senha_certa);

                System.Console.WriteLine("Informe sua data de nascimento (DD/MM/AAAA)");
                dataNascimento = DateTime.Parse(Console.ReadLine());

            #endregion

            #region Controller
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel();

                List<UsuarioViewModel> lsUsuarios = ListarUsuarios();

                usuarioViewModel.Id = lsUsuarios.Count + 1;
                usuarioViewModel.Nome = nome;
                usuarioViewModel.Email = email;
                usuarioViewModel.Senha = senha;
                usuarioViewModel.DataNascimento = dataNascimento;

                using(StreamWriter escrever = new StreamWriter("usuarios.csv", true)){
                        escrever.WriteLine($"{usuarioViewModel.Id};{usuarioViewModel.Nome};{usuarioViewModel.Email};{usuarioViewModel.Senha};{usuarioViewModel.DataNascimento}");
                }

                System.Console.WriteLine("Usuário Cadastrado");
                contador++;
            #endregion
        }
    
        public void Logar(){
            bool senha_certa = false;
            bool email_certo = false;
            
            #region View
                string email_login;
                string senha_login;

                do{
                    System.Console.WriteLine("Informe o seu email: ");
                    email_login = Console.ReadLine();

                    if(Verificacao_Email(email_login) == true){
                        senha_certa = true;
                        break;
                    } else{
                        System.Console.WriteLine("Email inválido");
                    }
                } while(!email_certo);

                do{
                    System.Console.WriteLine("Informe sua senha: ");
                    senha_login = Console.ReadLine();

                    if(Verificacao_Senha(senha_login) == true){
                        senha_certa = true;
                        MenuFinanceiro();
                    } else{
                        System.Console.WriteLine("Senha Inválida");
                    }
                } while(!senha_certa);

            #endregion

            #region Controller
                List<UsuarioViewModel> lsUsuarios = ListarUsuarios();

                foreach (UsuarioViewModel item in lsUsuarios)
                {
                    if(item.Email == email_login && item.Senha == senha_login){
                        System.Console.WriteLine("Acesso liberado");
                        break;
                    }
                }
            #endregion
        }
    
        private List<UsuarioViewModel> ListarUsuarios(){
            #region Controller
                List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();
                UsuarioViewModel usuario;

                string[] linhas = File.ReadAllLines("usuarios.csv");

                foreach (string item in linhas){
                    string[] dados = item.Split(";");
                    usuario = new UsuarioViewModel();
                    usuario.Id = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.Senha = dados[3];
                    usuario.DataNascimento = DateTime.Parse(dados[4]);
                    lsUsuarios.Add(usuario);
                }

                return lsUsuarios;
            #endregion
        }
    }
}