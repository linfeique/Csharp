using System;

namespace Senai.Exercicios.While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o fator da tabuada: ");
            short fator = short.Parse(Console.ReadLine());

            short contador = 0;

            while (contador >= 0){
                int valor = fator * contador;
                Console.WriteLine($"{fator} x {contador} = {valor}");
                contador++;
            }
        }
    }
}
