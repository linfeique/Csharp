using System.Collections.Generic; //Sem isso, a lista não funciona.
using exemplo_2510.ViewModels;
using System;
using exemplo_2510.Util;

namespace exemplo_2510.Repositorio
{
    /// <summary>
    /// Classe responsável pela leitura e gravação dos dados referentes ao usuário.
    /// </summary>
    
    public class UsuarioRepositorio
    {
        //Poderíamos usar o vetor, mas usaremos o list por ser mais fácil de trabalhar.
        //List<tipodados> nomevariavel = new List<tiopodados>();    
    
        //Criação do objeto List<UsuarioViewModel> que faz parte do namespace System.Collections.Generic.

        //Isto é um instanciamento.        
        static List<UsuarioViewModel> listUsuarios = new List<UsuarioViewModel>();

        /// <summary>
        /// Método par inserir um novo usuário.
        /// </summary>
        /// <param name="usuario">Objeto UsuarioViewModel (nome, email, senha)</param>
        /// <returns>Retorna um UsuarioViewModel atualizado.</returns>
        
        public UsuarioViewModel Inserir(UsuarioViewModel usuario)//O primeiro UsuarioViewModel é tipo de dados. O segundo é para se referir ao objeto da classe.   
        {
            //Atribui um valor ao ID, verifica a quantidade de itens na lista e soma 1.
            //Count retorna o número de elementos. O exercício pediu que as Ids começassem em um.
            usuario.Id = listUsuarios.Count + 1;  
            //Atribui a data e hora atuais do sistema;
            usuario.DataCriacao = DateTime.Now;
            //Adiciona o usuário a Lista.
            listUsuarios.Add(usuario); 
            //retorna o usuário
            return usuario;
        }

        /// <summary>
        /// Lista todos os usuários.
        /// </summary>
        /// <returns>Retorna um List<UsuarioViewModel></returns>
        public List<UsuarioViewModel> Listar()
        {
            return listUsuarios;
        }

        /// <summary>
        /// Verifica se o usuário é válido.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>Retorna um usuário se for válido ou um null se não for.</returns>
        public UsuarioViewModel Login(string email, string senha)
        {
            //Percorre a lista de Usuários
            foreach (UsuarioViewModel item in listUsuarios)
            {
                //Verifica se o item/objeto email e senha são iguais ao que foi passado como parâmetro
                if(item.Email == email && item.Senha == senha)
                {
                    //retorna o item/UsuarioViewModel
                    return item;
                }
            }
            //Caso não encontre o usuário, retorna null.
            return null;
        }
    }
}