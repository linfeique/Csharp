using System;
using Senai.Exercicios.Metodo3.classes;

namespace Senai.Exercicios.Metodo3 {
    class Program {
        static void Main (string[] args) {
            Retangulo retangulo = new Retangulo ();

            Console.WriteLine ("Informe o valor do lado A: ");
            retangulo.lado1 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe o valor do lado B: ");
            retangulo.lado2 = float.Parse (Console.ReadLine ());

            float perimetro = calcularPerimetro(retangulo.lado1, retangulo.lado2);
            
            float area = calcularArea(retangulo.lado1, retangulo.lado2);

            Console.WriteLine ($"O perimetro desse retângulo é {perimetro}");
            Console.WriteLine ($"\nA área desse retângulo é {area}");
        }

        static float calcularArea (float ladoA, float ladoB) {
            float area_metodo;
            area_metodo = ladoA * ladoB;
            return area_metodo;
        }

        static float calcularPerimetro (float ladoA, float ladoB) {
            float perimetro_metodo;
            perimetro_metodo = (ladoA * 2) + (ladoB * 2);
            return perimetro_metodo;
        }
    }
}