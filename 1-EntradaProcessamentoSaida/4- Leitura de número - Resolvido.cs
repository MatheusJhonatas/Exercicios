Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
multiplicações.

Meu código: 
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

Código do chat GPT

using System;

class Program
{
    static void Main()
    {
        int A, B, C, D;

        Console.WriteLine("Digite quatro valores inteiros:");
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        // Adições
        int somaAB = A + B;
        int somaAC = A + C;
        int somaAD = A + D;
        int somaBC = B + C;
        int somaBD = B + D;
        int somaCD = C + D;

        // Multiplicações
        int multAB = A * B;
        int multAC = A * C;
        int multAD = A * D;
        int multBC = B * C;
        int multBD = B * D;
        int multCD = C * D;

        Console.WriteLine($"Resultados das adições:");
        Console.WriteLine($"A + B = {somaAB}");
        Console.WriteLine($"A + C = {somaAC}");
        Console.WriteLine($"A + D = {somaAD}");
        Console.WriteLine($"B + C = {somaBC}");
        Console.WriteLine($"B + D = {somaBD}");
        Console.WriteLine($"C + D = {somaCD}");

        Console.WriteLine($"Resultados das multiplicações:");
        Console.WriteLine($"A * B = {multAB}");
        Console.WriteLine($"A * C = {multAC}");
        Console.WriteLine($"A * D = {multAD}");
        Console.WriteLine($"B * C = {multBC}");
        Console.WriteLine($"B * D = {multBD}");
        Console.WriteLine($"C * D = {multCD}");

        Console.ReadLine();
    }
}
