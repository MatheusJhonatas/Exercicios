/*45) Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura:*/

using System;

namespace Exercicios
{
    public class Exercicio45
    {
        public static void Main()
        {
            Console.WriteLine("Digite a quantidade de números que deseja inserir:");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite o primeiro {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Números que você digitou imprimidos na ordem inversa:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}