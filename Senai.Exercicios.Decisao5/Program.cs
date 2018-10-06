using System;

namespace Senai.Exercicios.Decisao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            if (num1 > num2){
                Console.WriteLine($"O valor {num1} é maior que {num2}");
            } else{
                Console.WriteLine($"O valor {num2} é maior que {num1}");
            }
        }
    }
}