/*56) Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números pares e de múltiplos de 5.*/

using System;

namespace Exercicio
{
    public class Exercicio56
    {
        public static void Main()
        {
            int numberPar = 0;
            int numberDiv5 = 0;
            int[] vet = new int[50];
            while (vet[0] != -1)
            {
                Console.WriteLine("Digite no máximo 50 números ou digite -1 para sair:");
                vet[0] = int.Parse(Console.ReadLine());

                if (vet[0] % 2 == 0)
                {
                    numberPar++;
                }
                if (vet[0] % 5 == 0)
                {
                    numberDiv5++;
                }
            }
            Console.Clear();
            Console.WriteLine("Quantidade de números pares: " + numberPar);
            Console.WriteLine($"Quantidade de números múltiplos de 5: {numberDiv5}");


        }
    }
}
