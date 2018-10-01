using System;

namespace Senai.Exercicios.Decisao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quanto você recebe: ");
            float salario = float.Parse(Console.ReadLine());

            if (salario <= 1000){
                float acres_25 = (salario * 125) / 100;
                Console.WriteLine($"Seu acréscimo é 25% e seu salário ficou em R$ {acres_25},00");
            }

            if (salario > 1000 && salario <= 2000){
                float acres_15 = (salario * 115) / 100;
                Console.WriteLine($"Seu acréscimo é 15% e seu salário ficou em R$ {acres_15},00");
            }

            if (salario > 2000){
                float acres_10 = (salario * 110) / 100;
                Console.WriteLine($"Seu acréscimo é 10% e seu salário ficou em R$ {acres_10},00");
            }
        }
    }
}