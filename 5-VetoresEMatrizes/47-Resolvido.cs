/*47) Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo e maior que zero. 
Faça um programa para:
a. ler pelo teclado o vetor;
b. ler pelo teclado o número X;
c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.*/

using System;
namespace Exercicio
{
    public class Program
    {
        public static void Main()
        {
            int[] vetor = new int[10];
            int x;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número:");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] < 0)
                {
                    Console.WriteLine("Vetor inválido. Encerrando o programa.");
                    return;
                }

            }
            Console.WriteLine("Digite o número X: ");
            x = int.Parse(Console.ReadLine());

        }

    }
}