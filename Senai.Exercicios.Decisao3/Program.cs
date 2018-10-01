using System;

namespace Senai.Exercicios.Decisao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            int c = Int32.Parse(Console.ReadLine());

            Boolean a_b = a > b;
            Boolean a_c = a > c;
            Boolean b_c = b > c;

            if (a_b == true && a_c == true){
                Console.WriteLine("O 'a' é o maior de todos");
                if (a_b == true && a_c == false){
                    Console.WriteLine("O 'c' é o maior de todos");
                } else {
                    Console.WriteLine("O 'b' é o maior de todos");
                }
            } else {
                Console.WriteLine("O 'a' é o menor de todos");
            }

            /* 
                if (a > b && a > c){
                    maior = a;
                } else if (b > c){
                    maior = b;
                } else{
                    maior = c;
                }
            */
        }
    }
}