/*34) Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.
Meu código:*/
using System;

namespace Exercicio34
{
    public class Program
    {
        public static void Main()
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int numero;
            while (true)
            {
                Console.WriteLine("Digite um número positivo (ou se quiser sair, digite um número negativo)");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                    break;
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine($"Maior número digitado: {maior}");
            Console.WriteLine($"Menor número digitado: {menor}");
        }
    }
}
