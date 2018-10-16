using System;

namespace Senai.For.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o limite: ");
            int limite = int.Parse(Console.ReadLine());

            // int cont = 0;
            // while (cont <= limite){
            //     
            //     cont++;
            // }

            for (int i = 0; i <= limite; i++){
                Console.WriteLine($"{x} x {i} = {x * i}");
            }
        }
    }
}
