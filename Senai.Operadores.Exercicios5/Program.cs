﻿using System;

namespace Senai.Operadores.Exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preço do produto: ");
            float p = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade minima desse produto no estoque: ");
            byte qMin = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Informe a quantidade máxima desse produto no estoque: ");
            byte qMax = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Informe a quantidade atual desse produto no estoque: ");
            byte ea = Convert.ToByte(Console.ReadLine());

            int em = (qMin  + qMax) / 2;
            Console.WriteLine($"O estoque médio é: {em}");

            int ct_em = ;
        }
    }
}
