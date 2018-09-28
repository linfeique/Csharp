using System;
using Senai.POO.Exercicios3.classes;

namespace Senai.POO.Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            conta c1 = new conta();
            conta c2 = new conta();
            conta c3 = new conta();

        #region cliente1
            Console.WriteLine("Informe o nome do cliente 1: ");
            c1.name = Console.ReadLine();

            Console.WriteLine("Informe o número de conta do cliente 1: ");
            c1.num_conta = Console.ReadLine();

            Console.WriteLine("Informe qual o saldo do cliente 1: ");
            c1.saldo = float.Parse(Console.ReadLine());
        #endregion

        #region cliente2
            Console.WriteLine("Informe o nome do cliente 2: ");
            c2.name = Console.ReadLine();

            Console.WriteLine("Informe o número de conta do cliente 2: ");
            c2.num_conta = Console.ReadLine();

            Console.WriteLine("Informe qual o saldo do cliente 2: ");
            c2.saldo = float.Parse(Console.ReadLine());
        #endregion

        #region cliente3
            Console.WriteLine("Informe o nome do cliente 3: ");
            c3.name = Console.ReadLine();

            Console.WriteLine("Informe o número de conta do cliente 3: ");
            c3.num_conta = Console.ReadLine();

            Console.WriteLine("Informe qual o saldo do cliente 3: ");
            c3.saldo = float.Parse(Console.ReadLine());
        #endregion
    
        Console.WriteLine("----------------------------------");
        // Cliente 1
        Console.WriteLine($"\nO nome do primeiro cliente é {c1.name}");
        Console.WriteLine($"\nO número de conta de {c1.name} cliente é {c1.num_conta}");
        Console.WriteLine($"\nO saldo de {c1.name} cliente é {c1.saldo}");

        Console.WriteLine("----------------------------------");
        // Cliente 2
        Console.WriteLine($"\nO nome do segundo cliente é {c2.name}");
        Console.WriteLine($"\nO número de conta de {c2.name} cliente é {c2.num_conta}");
        Console.WriteLine($"\nO saldo de {c2.name} cliente é {c2.saldo}");

        Console.WriteLine("----------------------------------");
        // Cliente 3
        Console.WriteLine($"\nO nome do terceiro cliente é {c3.name}");
        Console.WriteLine($"\nO número de conta de {c3.name} cliente é {c3.num_conta}");
        Console.WriteLine($"\nO saldo de {c3.name} cliente é {c3.saldo}");

        Console.WriteLine("----------------------------------");
        Console.WriteLine("\n----------------------------------");
        float soma = c1.saldo + c2.saldo + c3.saldo;
        Console.WriteLine($"\nA soma dos saldos de todas as contas é R$ {soma},00");
        }
    }
}
