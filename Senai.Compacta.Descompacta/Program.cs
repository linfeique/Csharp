using System;
using System.IO.Compression;

namespace Senai.Compacta.Descompacta
{
    class Program
    {
        static string opcao;

        static void Main(string[] args)
        {
            do{
            System.Console.WriteLine("--------- Bem-Vindo ---------");
            System.Console.WriteLine("1 - Compactar");
            System.Console.WriteLine("2 - Descompactar");

            System.Console.WriteLine("Insira uma opção: ");
            opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                    System.Console.WriteLine("Insira o diretório que será compactado: ");
                    string diretorioParaCompactar = Console.ReadLine();

                    System.Console.WriteLine("Insira o nome do arquivo .zip: ");
                    string arquivoZipDestino = Console.ReadLine();

                    if(!){
                        ZipFile.CreateFromDirectory (diretorioParaCompactar, arquivoZipDestino);
                    }
                break;

                case "2":
                    System.Console.WriteLine("Insira o nome do arquivo .zip a ser descompactado: ");
                    string arquivoZip = Console.ReadLine();

                    System.Console.WriteLine("Insira o nome do diretório após a compactação: ");
                    string diretorioDestino = Console.ReadLine();

                    ZipFile.ExtractToDirectory(arquivoZip, diretorioDestino);
                break;

                default:
                    System.Console.WriteLine("Opção inválida");
                break;
            }
            } while(opcao != "0");
        }
    }
}
