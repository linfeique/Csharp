using System;

namespace Senai.DoWhile.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float soma =0;
            float media = 0;
            float num;
            do{
            Console.WriteLine("Digite um número:");
            num = float.Parse(Console.ReadLine());

            // O sinal "+=" serve para somar a variavel da posição "A" com a da posição "B" e guarda esse valor na variavel da
            //posição "B";
            soma += num;
            media ++;
            System.Console.WriteLine($"Soma dos números= {soma}");
            System.Console.WriteLine($"Media dos números= {soma/media}");
            }
            while(num !=0);
            
        }
    }
}