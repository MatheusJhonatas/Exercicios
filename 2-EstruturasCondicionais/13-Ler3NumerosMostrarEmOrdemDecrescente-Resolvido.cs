/*Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.*/

using System;

namespace Ordenacao_numeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            int[] n = new int[3];
            n[0] = int.Parse(Console.ReadLine());
            n[1] = int.Parse(Console.ReadLine());
            n[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Os números que você digitou em ordem decrescente.");
            Console.WriteLine(n[2]);
            Console.WriteLine(n[1]);
            Console.WriteLine(n[0]);
        }
    }
}

/*Código do chatgpt:


using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[3];

        // Lendo os números
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordenando os números em ordem decrescente
        Array.Sort(numeros);
        Array.Reverse(numeros);

        // Imprimindo os números em ordem decrescente
        Console.WriteLine("\nNúmeros em ordem decrescente:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}*/
