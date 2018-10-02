using System;

namespace Senai.Exercicios.Decisao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            if (valor1 % 2 == 0 ){
                Console.WriteLine("O valor é divisivel por dois");
                if(valor1 % 3 == 0){
                    Console.WriteLine("O valor não é divisivel por tres");
                } else if(valor1 % 2 == 0 && valor1 % 3 == 0){
                Console.WriteLine("O valor é divisivel por tres e por dois");
            } else{
                Console.WriteLine("O valor não é divisivel por tres e nem por dois");
            }

            Console.WriteLine("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor2 % 2 == 0 && valor2 % 3 == 0){
                Console.WriteLine("O valor é divisivel por dois e por tres");
            } else{
                Console.WriteLine("O valor não é divisivel por dois nem por tres");
            }

            Console.WriteLine("Informe o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor3 % 2 == 0 && valor3 % 3 == 0){
                Console.WriteLine("O valor é divisivel por dois e por tres");
            } else{
                Console.WriteLine("O valor não é divisivel por dois nem por tres");
            }

            Console.WriteLine("Informe o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());

            if (valor4 % 2 == 0 && valor4 % 3 == 0){
                Console.WriteLine("O valor é divisivel por dois e por tres");
            } else{
                Console.WriteLine("O valor não é divisivel por dois nem por tres");
            }
        }
    }
}
