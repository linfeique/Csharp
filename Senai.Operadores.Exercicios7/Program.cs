using System;

namespace Senai.Operadores.Exercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em reais: ");
            float valor_reais = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em dolar: ");
            float valor_dolar = float.Parse(Console.ReadLine());

            float valor_dol_em_re = valor_dolar * 4;
            Console.WriteLine($"\nVocê tem R$ { valor_dol_em_re },00 em reais");

            float valor_to_re = valor_dol_em_re + valor_reais;
            Console.WriteLine($"Você tem R$ { valor_to_re },00 no total");  
        }
    }
}
