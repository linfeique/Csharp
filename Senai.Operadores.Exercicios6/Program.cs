using System;

namespace Senai.Operadores.Exercicios6 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Informe o nome do produto: ");
            string nome = Console.ReadLine ();

            Console.WriteLine ("Informe o preço do produto: ");
            float preco = float.Parse (Console.ReadLine ());

            float preco_descont = (preco * 10) / 100;
            Console.WriteLine ($"\nO nome do produto é: { nome }");
            Console.WriteLine ($"\nO preço do produto sem desconto é: R$ { preco },00");
            Console.WriteLine ($"\nO preço com desconto é: R$ { preco_descont },00");
        }
    }
}