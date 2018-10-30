using System;
using System.IO;

namespace Ler.Texto.Prangarico.Tirimihuaru {
    class Program {

        static int[] numeros = new int[5];
        static string Linha;
        static Random rand = new Random ();
        static string arqTexto = @"C:\Users\44680479841\Desktop\string.txt";
        static void Main (string[] args) {
            if (System.IO.File.Exists (@"C:\Users\44680479841\Desktop\string.txt")) {
                using (StreamReader Ler = new StreamReader (arqTexto)) {
                    StreamReader re = File.OpenText (@"C:\Users\44680479841\Desktop\string.txt");
                    string input = re.ReadToEnd ();
                    System.Console.WriteLine("Qualquer coisa");

                    if (input.IndexOf ("Usuário") > -1) {
                        System.Console.WriteLine ("Existe palabra");

                        while ((Linha = Ler.ReadLine ()) != null) {
                            System.Console.WriteLine ($"{Linha}");
                        }
                    }
                }


            } else {

                for (int i = 0; i < 5; i++) {
                    numeros[i] = rand.Next (1000);
                }

                //Cria uma instância se StreamWriter para escrever em um arquivo de texto
                //A declaração using fecha o Stream
                using (StreamWriter Escreve = new StreamWriter (arqTexto)) {
                    //Escreve apenas uma linha e seguem na mesma
                    for (int i = 0; i < 5; i++) {
                        Escreve.WriteLine (numeros[i]);
                    }

                }
                using (StreamReader Ler = new StreamReader (arqTexto)) {
                    string Linha;
                    while ((Linha = Ler.ReadLine ()) != null) {
                        System.Console.WriteLine ($"{Linha}");
                    }

                }

            }
        }
    }
}