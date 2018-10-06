using System;

namespace Senai.Exercicios.Decisao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o dia em que você nasceu: ");
            short NascDia = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o mês em que você nasceu: ");
            short NascMes = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o ano em que você nasceu: ");
            short NascAno = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Em que ano você está: ");
            short AnoAtual = Convert.ToInt16(Console.ReadLine());

            if (AnoAtual - NascAno >= 16){
                Console.WriteLine($"Você nasceu em {NascDia}/{NascMes}/{NascAno} e pode votar");
            } else{
                Console.WriteLine($"Você nasceu em {NascDia}/{NascMes}/{NascAno} e não pode votar");
            }


            
        }
    }
}
