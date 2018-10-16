using System;

namespace Senai.Sistema.Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta, cont = 0, contE;
            int[] numPassagem = new int[2];
            string[] nomePassageiro = new string[2];
            DateTime[] dataVoo = new DateTime[2];

            do{
                Console.WriteLine("--------- Digite uma opção ---------");
                Console.WriteLine("1 - Agendar Viagem");
                Console.WriteLine("2 - Exibir Viagens");
                Console.WriteLine("0 - Sair");
                resposta = Convert.ToInt32(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        if (cont < 2){
                            Console.WriteLine("Digite o nome do passageiro");
                            nomePassageiro[cont] = Console.ReadLine();
                            Console.WriteLine("Digite o número da passagem");
                            numPassagem[cont] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data do voo (dd/mm/aaaa)");
                            dataVoo[cont] = DateTime.Parse(Console.ReadLine());
                            cont++;
                        }else{
                            Console.WriteLine("Limite Excedido");
                        }
                    break;

                    case 2:
                        contE = 0;
                        while (contE < cont){
                            Console.WriteLine($"--- Passageiro {contE+1}");
                            Console.WriteLine($"Nome: {nomePassageiro[contE]}");
                            Console.WriteLine($"Nº Passagem: {numPassagem[contE]}");
                            Console.WriteLine($"Data: {dataVoo[contE].ToShortDateString()}");
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
