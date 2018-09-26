using System;

namespace Senai.Operadores.Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region imcpessoa1
                Console.WriteLine("Informe o peso da primeira pessoa: ");
                float pesoPessoa1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura da primeira pessoa: ");
                float alturaPessoa1 = float.Parse(Console.ReadLine());

                float imcPessoa1 = (float) (pesoPessoa1 / Math.Pow(alturaPessoa1, 2));
                Console.WriteLine("O peso da pessoa 1 é:" +pesoPessoa1+ "\nA altura da pessoa 1 é: " +alturaPessoa1+ "\nE tem imc de: "+imcPessoa1);

                if (imcPessoa1 > 18 && imcPessoa1 < 25){
                    Console.WriteLine("Você está no peso normal");
                }
                if (imcPessoa1 > 25 && imcPessoa1 < 30){
                    Console.WriteLine("Acima do Peso");
                }
                if (imcPessoa1 > 30 && imcPessoa1 < 35){
                    Console.WriteLine("Obesidade nivel 1");
                }
                if(imcPessoa1 > 35 && imcPessoa1 < 40){
                    Console.WriteLine("Obesidade nivel dois");
                }
                

                // vc tb pode usar a função Math.Pow(alturapessoa, 2)
            #endregion

            #region imcpessoa2
                Console.WriteLine("\n\nInforme o peso da segunda pessoa: ");
                float pesoPessoa2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura da segunda pessoa: ");
                float alturaPessoa2 = float.Parse(Console.ReadLine());

                float imcPessoa2 = pesoPessoa2 / (alturaPessoa2 * alturaPessoa2);
                Console.WriteLine("O peso da pessoa 2 é:" +pesoPessoa2+ "\nA altura da pessoa 2 é: " +alturaPessoa2+ "\nE tem imc de: "+imcPessoa2);
            
                if (imcPessoa2 > 18 && imcPessoa2 < 25){
                    Console.WriteLine("Você está no peso normal");
                }
                if (imcPessoa2 > 25 && imcPessoa2 < 30){
                    Console.WriteLine("Acima do Peso");
                }
                if (imcPessoa2 > 30 && imcPessoa2 < 35){
                    Console.WriteLine("Obesidade nivel 1");
                }
                if(imcPessoa2 > 35 && imcPessoa2 < 40){
                    Console.WriteLine("Obesidade nivel dois");
                }
            #endregion

            #region imcpessoa3
                Console.WriteLine("\n\nInforme o peso da terceira pessoa: ");
                float pesoPessoa3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura da terceira pessoa: ");
                float alturaPessoa3 = float.Parse(Console.ReadLine());

                float imcPessoa3 = pesoPessoa3 / (alturaPessoa3 * alturaPessoa3);
                Console.WriteLine("O peso da pessoa 3 é:" +pesoPessoa3+ "\nA altura da pessoa 3 é: " +alturaPessoa3+ "\nE tem imc de: "+imcPessoa3);
            
                if (imcPessoa3 > 18 && imcPessoa3 < 25){
                    Console.WriteLine("Você está no peso normal");
                }
                if (imcPessoa3 > 25 && imcPessoa3 < 30){
                    Console.WriteLine("Acima do Peso");
                }
                if (imcPessoa3 > 30 && imcPessoa3 < 35){
                    Console.WriteLine("Obesidade nivel 1");
                }
                if(imcPessoa3 > 35 && imcPessoa3 < 40){
                    Console.WriteLine("Obesidade nivel dois");
                }
            #endregion
        }
    }
}