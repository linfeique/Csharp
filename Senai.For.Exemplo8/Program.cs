using System;

namespace Senai.For.Exemplo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizinha = new int[5, 5];
            Random randomico = new Random();
            bool encontrou = false;

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    matrizinha[i, j] = randomico.Next(50);
                }
            }

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    Console.Write($"{matrizinha[i, j]}\t");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Insira um número: ");
            int numeroRecebido = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    if (numeroRecebido == matrizinha[i, j]){
                        System.Console.WriteLine($"Número encontrado na linha {i} e coluna {j}!!");
                        encontrou = true;
                        break;
                    }
                }
            }

            if (!encontrou){
                System.Console.WriteLine("O número não foi encontrado!!!");
            }
        }
    }
}
