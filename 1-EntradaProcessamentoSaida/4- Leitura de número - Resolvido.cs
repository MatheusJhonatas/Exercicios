/*Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
multiplicações.

Meu código:*/
using System;
using System.Globalization;

namespace Leitura_de_Numeros
{
    public class Numbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor D: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado das Adições: ");
            Console.WriteLine(a + b + "\n");
            Console.WriteLine(a + c + "\n");
            Console.WriteLine(a + d + "\n");
            Console.WriteLine(b + c + "\n");
            Console.WriteLine(b + d + "\n");
            Console.WriteLine(c + d + "\n");

            Console.WriteLine("Resultado das multiplicações: ");
            Console.WriteLine(a * b + "\n");
            Console.WriteLine(a * c + "\n");
            Console.WriteLine(a * d + "\n");
            Console.WriteLine(b * c + "\n");
            Console.WriteLine(b * d + "\n");
            Console.WriteLine(c * d + "\n");

        }
    }
}
