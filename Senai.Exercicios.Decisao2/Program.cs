using System;

namespace Senai.Exercicios.Decisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recebendo o gênero
            Console.WriteLine("Insira o gênero [M/F]: ");
            char genero = char.Parse(Console.ReadLine());

            if (genero == 'M'){

                // Recebendo a idade
                Console.WriteLine("Informe a sua idade: ");
                int idade = Int32.Parse(Console.ReadLine());

                if(idade >= 17){
                    System.Console.WriteLine("Já pode tirar a reservista");
                } else{
                    System.Console.WriteLine("Você não pode tirar a reservista");
                }

            } else{
                System.Console.WriteLine("Você não pode tirar a reservista");
            }
        }
    }
}
