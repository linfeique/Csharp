using System;
using System.IO;

namespace Senai.Control.f
{
    class Program
    {
        static string leitura;
        static bool achou;

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo");
            System.Console.WriteLine("Qual o nome do arquivo que você quer procurar a palavra?");
            string nome_arquivo = Console.ReadLine();

            using(StreamReader ler = new StreamReader(nome_arquivo)){
                do{
                    if(File.Exists(nome_arquivo)){
                        System.Console.WriteLine("Arquivo achado e sendo lido");
                        leitura = ler.ReadToEnd();
                        achou = true;
                    } else {
                        System.Console.WriteLine("Esse arquivo não existe, crie ele e depois tente de novo");
                        System.Console.WriteLine("Aperte alguma tecla");
                        Console.ReadKey();
                    }
                } while(achou != true);
            }

            System.Console.WriteLine("Qual a palavra que você quer achar: ");
            string palavra_achar = Console.ReadLine();

            using(StreamWriter escrever = new StreamWriter(nome_arquivo)){
                if(leitura.Contains(palavra_achar)){
                    using(StreamReader ler = new StreamReader(nome_arquivo)){
                        leitura = ler.ReadToEnd();
                    }
                    
                    for(int i = 0; i < 5; i++){
                        escrever.WriteLine(leitura);
                    }
                }
            }
        }
    }
}
