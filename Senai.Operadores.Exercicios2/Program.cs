using System;

namespace Senai.Operadores.Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a base do triângulo: ");
            byte base_triangulo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Informe a altura do triângulo: ");
            byte altura_triangulo = Convert.ToByte(Console.ReadLine());

            int area_triangulo = base_triangulo * altura_triangulo;
            Console.WriteLine($"A base do triangulo é: { area_triangulo }");
        }
    }
}