using System;
using Senai.Sistema.Viagem.classes;

namespace Senai.Sistema.Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta, cont = 0, contE = 0;
            Passagem[] passagens = new Passagem[3];

            do{
                Console.WriteLine("--------- Digite uma opção ---------");
                Console.WriteLine("1 - Agendar Viagem");
                Console.WriteLine("2 - Exibir Viagens");
                Console.WriteLine("0 - Sair");
                resposta = Convert.ToInt32(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        if (cont < 3){
                            passagens[cont] = new Passagem();
                            Console.WriteLine("Digite o nome do passageiro");
                            passagens[cont].NomePassageiro = Console.ReadLine();
                            Console.WriteLine("Digite o número da passagem");
                            passagens[cont].Numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data do voo (dd/mm/aaaa)");
                            passagens[cont].Data = DateTime.Parse(Console.ReadLine());
                            cont++;
                        }else{
                            Console.WriteLine("Limite Excedido");
                        }
                    break;

                    case 2:
                        while (contE < cont){
                            Console.WriteLine($"--- Passageiro {contE+1}");
                            Console.WriteLine($"Nome: {passagens[contE].NomePassageiro}");
                            Console.WriteLine($"Nº Passagem: {passagens[contE].Numero}");
                            Console.WriteLine($"Data: {passagens[contE].Data.ToShortDateString()}");
                            contE++;
                        }
                    break;

                    case 0:
                        Console.WriteLine("A Tsukamoto Airlines agradece!");
                    break;

                    default:
                        Console.WriteLine("Opção Inválida");
                    break;
                }
            } while(resposta != 0);
        }
    }
}
