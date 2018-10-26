using System;
using System.Collections.Generic;
using exemplo_2510.Repositorio;
using exemplo_2510.Util;
using exemplo_2510.ViewModels;
using exemplo_2510.ViewsControllers;

namespace exemplo_2510
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;

            do
            {
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                    {
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    }

                    case 3:
                    {
                        UsuarioViewController.Listar();
                        break;
                    }
                    
                    case 0:
                    {
                        System.Console.WriteLine("Tchau.");
                        break;
                    }

                    default:
                    {
                        System.Console.WriteLine("Opção inválida.");
                        break;
                    }

                }

            }while (opcaoDeslogado !=0);
            
        }
    }
}
