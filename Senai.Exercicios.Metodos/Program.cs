using System;

namespace Senai.Exercicios.Metodos {
    class Program {
        static void Main (string[] args) {
            int soma, valor1, valor2;

            Console.WriteLine ("Digite o valor do número 1: ");
            valor1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o valor do número 2: ");
            valor2 = int.Parse (Console.ReadLine ());

            soma = somarNumeros(valor1, valor2);

            Console.WriteLine($"A soma é {soma.ToString()}");
        }
        // Método para somar dois números

        static int somarNumeros (int num1, int num2) {
            int resultado = num1 + num2;
            return resultado;
        }

    }
}