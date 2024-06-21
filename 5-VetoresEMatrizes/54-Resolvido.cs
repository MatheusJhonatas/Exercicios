/*54) Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C# que imprima todos os elementos comuns aos dois vetores.*/

using System;
using System.Numerics;

namespace Exercicio54
{
    public class Exercicios
    {
        public static void Main()
        {

            int[] A = new int[5];
            int[] B = new int[8];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número do vetor A: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Obrigado, você digitou os números do vetor A");
            Console.WriteLine("Agora digite os números do vetor B =>\n");

            Console.WriteLine("Carregando...");
            Thread.Sleep(4500);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número do vetor B: ");
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Números comuns aos vetores A e B:");

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        Console.WriteLine(A[i]);
                        break;
                    }
                }
            }
        }
    }
}