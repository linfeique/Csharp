using System;

namespace Senai.Exercicios.Decisao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debian GNU/Linux 7 debian tty1");
            Console.WriteLine("\n\ndebian login: ");
            Console.ReadLine();
            Console.WriteLine("\nPassword: ");
            short senha = Convert.ToInt16(Console.ReadLine());
            if (senha == 1234){
                Console.WriteLine("ACESSE PERMITIDO");
            } else{
                Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
