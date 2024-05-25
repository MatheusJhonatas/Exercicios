/*36) Faça um programa que leia 10 valores inteiros e positivos e:
- Encontre o maior valor
- Encontre o menor valor
- Calcule a média dos números lidos
Meu código:*/

using System;

namespace Exercicio36
{
    public class Program
    {
        public static void Main()
        {
            const int quantidadeNumeros = 10;
            int[] valores = new int[quantidadeNumeros];
            int maiorNumero = int.MinValue;
            int menorNumero = int.MaxValue;
            double soma = 0;

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.WriteLine($"Digite o numero {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    break;
                }
                else
                {
                    // Atualiza o maior e o menor número
                    maiorNumero = Math.Max(maiorNumero, numero);
                    menorNumero = Math.Min(menorNumero, numero);

                    // Soma os valores para calcular a média
                    soma += numero;
                }


            }
            double media = soma / quantidadeNumeros;
            Console.WriteLine($"Maior número digitado: {maiorNumero}");
            Console.WriteLine($"Menor número digitado: {menorNumero}");
            Console.WriteLine($"A média dos números digitado é: {media} ");

        }
    }
}
