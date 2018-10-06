using System;

namespace Senai.Exercicios.Decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número à ser verificado");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0){
                Console.WriteLine("Esse número é positivo");
            } else{
                Console.WriteLine("Esse número é negativo");
            }
        }
    }
}