using System;
using System.Collections.Generic; //Sem isso, o listar não funciona.
using exemplo_2510.Repositorio;
using exemplo_2510.Util;
using exemplo_2510.ViewModels;

namespace exemplo_2510.ViewsControllers {
    public static class UsuarioViewController {
        /// <summary>
        /// Tela de cadastro de usuário
        /// </summary>
        public static void CadastrarUsuario () {
            string email, nome, senha;

            do {
                System.Console.WriteLine ("Informe seu nome: ");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome))
                    System.Console.WriteLine ("Nome inválido.");
            } while (string.IsNullOrEmpty (nome)); //Se o usuário der só enter sem digitar o nome, o programa pede o nome novamente

            do {
                System.Console.WriteLine ("Informe seu e-mail: ");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email))
                    System.Console.WriteLine ("E-mail inválido");

            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe sua senha: ");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha))
                    System.Console.WriteLine ("Senha inválida");

            } while (!ValidacaoUtil.ValidarSenha (senha));


            #region Controller
            //Cria um objeto do Tipo UsuarioViewModel
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            //Atribui os valores de propriedades
                usuarioViewModel.Nome = nome;
                usuarioViewModel.Email = email;
                usuarioViewModel.Senha = senha;

            //Cria um objeto do Tipo UsuarioRepositorio
                UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            //Insere um novo usuário    
                usuarioRepositorio.Inserir(usuarioViewModel);

            //Mostra mensagem ao usuário.
                System.Console.WriteLine("Usuário Cadastrado.");
            #endregion

        }

        public static void Listar()
        {
            //Cria um objeto do tipo UsuarioRepositorio.
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            
            //Retorna a lista de usuários cadastrados.
            List<UsuarioViewModel> listUsuarios = usuarioRepositorio.Listar();

            //Percorre a lista de usuários
            foreach (UsuarioViewModel item in listUsuarios)
            {
                //Mostra na tela os dados do usuário, exceto a senha.
                System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email}");
            }
        }
    }
}