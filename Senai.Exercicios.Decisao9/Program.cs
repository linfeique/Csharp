using System;

namespace Senai.Exercicios.Decisao9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            float num3 = float.Parse(Console.ReadLine());

            Boolean num1_num2 = num1 > num2;
            Boolean num1_num3 = num1 > num3;
            Boolean num2_num3 = num2 > num3;

            if(num1_num2 == true && num1_num3 == true && num2_num3 == true){
                Console.WriteLine($"Sequência: {num3} {num2} {num1}");
            } else if(num1_num2 == false && num1_num3 == false && num2_num3 == true){
                Console.WriteLine($"Sequência: {num1} {num3} {num2}");
            } else if(num1_num2 == true && num1_num3 == false && num2_num3 == false){
                Console.WriteLine($"Sequência: {num2} {num1} {num3}");
            } else if(num1_num2 == false && num1_num3 == false && num2_num3 == false){
                Console.WriteLine($"Sequência: {num1} {num2} {num3}");
            } else if(num1_num2 == true && num1_num3 == true && num2_num3 == false){
                Console.WriteLine($"Sequência: {num2} {num3} {num1}");
            } else if(num1_num2 == false && num1_num3 == true && num2_num3 == true){
                Console.WriteLine($"Sequência: {num3} {num1} {num2}");
            } else {
                Console.WriteLine("Você é burro");
            }
        }
    }
}
