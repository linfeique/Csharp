using System;
using System.IO;

namespace Senai.Techtalk2.Classes {
    public class Metodos {
        static string leitura;

        public static void Menu () {
            System.Console.WriteLine ("1- Cadastrar user");
            System.Console.WriteLine ("2- Login");
            System.Console.WriteLine ("0- Sair");
        }

        public static void Verifi_Arq () {
            if (File.Exists ("banco_dados.txt")) {
                using (StreamReader ler = new StreamReader ("banco_dados.txt")) {
                    leitura = ler.ReadLine ();
                }
            } else {
                using (StreamWriter escrever = new StreamWriter ("banco_dados.txt", true)) {
                    escrever.WriteLine ("admin:admin");
                }
            }
        }

        public static bool Verifi_Usr (string nome) {
            using(StreamReader ler = new StreamReader("banco_dados.txt", true)){
                leitura = ler.ReadToEnd();
            }
            if (leitura.Contains (nome)) {
                System.Console.WriteLine ("Usuário já cadastrado");
                return true;
            } else {
                return false;
            }
        }

        public static void Cadastro () {

            System.Console.WriteLine ("Qual o nome do usuário: ");
            string nome = Console.ReadLine ();

            if (Verifi_Usr (nome) == false) {
                using (StreamWriter escrever = new StreamWriter ("banco_dados.txt", true)) {
                    escrever.Write (nome + ":");
                    System.Console.WriteLine ($"Qual a senha do {nome}");
                    string senha = Console.ReadLine ();
                    escrever.WriteLine (senha);
                }
            }
        }

        public static void EfetuarLogin () {
            using (StreamReader ler = new StreamReader ("banco_dados.txt", true)) {
                string leitura2 = ler.ReadToEnd ();
                System.Console.WriteLine ("Qual o nome do usuário: ");
                string nome_login = Console.ReadLine ();
                if (leitura2.Contains (nome_login)) {
                    System.Console.WriteLine ("Qual sua senha: ");
                    string senha = Console.ReadLine ();
                    if (leitura2.Contains (senha)) {
                        System.Console.WriteLine ("Usuário logado");
                    } else {
                        System.Console.WriteLine ("Senha incorreta");
                    }
                } else {
                    System.Console.WriteLine ("Usuário incorreto");
                }
            }
        }
    }
}