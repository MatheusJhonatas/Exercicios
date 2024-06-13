/*49) Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições.*/

using System;
namespace ExerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite quantos números inteiros quer digitar (no máximo 50): ");
            int n = int.Parse(Console.ReadLine());
            if (n > 50)
            {
                Console.WriteLine("O máximo é 50 números");
                return;
            }
            int[] v1 = new int[n];
            int[] v2 = new int[n];

            Console.WriteLine("Digite os números do primeiro vetor: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: ");
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite os números do segundo vetor: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: ");
                v2[i] = int.Parse(Console.ReadLine());
            }
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (v1[i] == v2[i])
                {
                    cont++;
                }
            }
            Console.WriteLine("Quantidade de elementos idênticos nas mesmas posições: " + cont);
        }
    }
}

