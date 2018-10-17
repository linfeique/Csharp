using System;

namespace Senai.Exercicios.DoWhile3 {
    class Program {
        static void Main (string[] args) {
            // int divisao = 0;
            int contador = 0;
            float divisor = 0;

            Console.WriteLine ("Insire o valor do dividendo: ");
            float dividendo = float.Parse (Console.ReadLine ());

            while (divisor == 0) {
                Console.WriteLine ("Insira um valor diferente de zero para o divisor: ");
                divisor = float.Parse (Console.ReadLine ());
            }

            do {
                dividendo -= divisor;
                contador++;
            } while (dividendo > 0);

            Console.WriteLine ($"O resultado da divisão é: {contador}");
        }
    }
}