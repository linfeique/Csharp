using System;

namespace Senai.Exercicios.While3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            short variavel = 1;

            while (variavel != 0){
                Console.Clear();
                Console.WriteLine($"\n\n==========Calculadora De Odin==========\n\n");
                Console.WriteLine("\n[1] Definir os valores de X e Y");
                Console.WriteLine("\n[2] Somar");
                Console.WriteLine("\n[3] Subtrair");
                Console.WriteLine("\n[4] Dividir");
                Console.WriteLine("\n[5] Potênciar");
                Console.WriteLine("\n[6] Multiplicar");
                Console.WriteLine("\n[0] Sair");
                Console.WriteLine("======================================");

                Console.WriteLine("\n\nEscolha uma das opções: ");
                variavel = short.Parse(Console.ReadLine());

                switch (variavel)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Defina os valores de X: ");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Defina os valores de Y: ");
                        y = int.Parse(Console.ReadLine());
                    break;

                    case 2:
                        if (x != 0 && y != 0){
                            Console.WriteLine($"A soma dos dois valores é {x + y}");
                            Console.WriteLine("\nAperte qualquer tecla para sair");
                            Console.ReadKey();
                        } else{
                            Console.WriteLine("Digite as variaveis primeiro");
                        }
                        Console.Clear();
                    break;

                    case 3:
                        if (x != 0 && y != 0){
                            Console.WriteLine($"A subtração dos dois valores é {x - y}");
                            Console.WriteLine("\nAperte qualquer tecla para sair");
                            Console.ReadKey();
                        } else{
                            Console.WriteLine("Digite as variaveis primeiro");
                        }
                        Console.Clear();
                    break;

                    case 4:
                        if (x != 0 && y != 0){
                            Console.WriteLine($"A divisão dos dois valores é {x / y}");
                            Console.WriteLine("\nAperte qualquer tecla para sair");
                            Console.ReadKey();
                        } else{
                            Console.WriteLine("Digite as variaveis primeiro");
                        }
                        Console.Clear();
                    break;

                    case 5:
                        if (x != 0 && y != 0){
                            Console.WriteLine($"A potenciação dos dois valores é {Math.Pow(x, y)}");
                            Console.WriteLine("\nAperte qualquer tecla para sair");
                            Console.ReadKey();
                        } else{
                            Console.WriteLine("Digite as variaveis primeiro");
                        }
                        Console.Clear();
                    break;

                    case 6:
                        if (x != 0 && y != 0){
                            Console.WriteLine($"A multiplicação dos valores é {x * y}");
                            Console.WriteLine("\nAperte qualquer tecla para sair");
                            Console.ReadKey();
                        } else{
                            Console.WriteLine("Digite as variaveis primeiro");
                        }
                        Console.Clear();
                    break;

                    case 0:
                        
                    break;

                    default:
                        Console.WriteLine("Seu otário!!!!");
                    break;
                }
            }
        }
    }
}