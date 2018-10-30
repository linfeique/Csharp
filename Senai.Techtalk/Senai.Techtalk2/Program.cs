using System;
using Senai.Techtalk2.Classes;

namespace Senai.Techtalk2 {
    class Program {
        static void Main (string[] args) {
            int resposta = 0;
            Metodos.Verifi_Arq();
            do {
                Console.WriteLine ("------ Bem-Vindo ------");
                Metodos.Menu ();
                resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {

                    case 1:
                        Metodos.Cadastro();
                    break;

                    case 2:
                        Metodos.EfetuarLogin();
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