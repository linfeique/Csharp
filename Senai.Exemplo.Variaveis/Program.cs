using System;

namespace Senai.Exemplo.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            byte idade;
            float altura;
            char sexo;
            DateTime dataNascimento;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            idade = Convert.ToByte(Console.ReadLine());

            if (idade < 18){
                Console.WriteLine("Você não pode beber ainda");
            } else{
                Console.WriteLine("Você já pode beber, mas com moderação");
            }

            Console.WriteLine("Informe sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Informe sua data de nascimento: ");
            dataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Nome: " +nome+ "\nIdade: " +idade+ "\nAltura: " +altura+ "\nSexo: " +sexo+ "\nData de Nascimento: " +dataNascimento);
        }
    }
}
