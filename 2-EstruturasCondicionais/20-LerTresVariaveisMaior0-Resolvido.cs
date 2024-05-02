/*Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). 

Ler um valor maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). 

Exibe o menor valor lido
multiplicado pelo maior e o maior valor dividido pelo menor.

Meu código: */
using System;
namespace Exercicio20
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite um valor maior que 0");
            int a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Ler novamente");
            }
            Console.WriteLine("Digite segundo valor maior que 0");
            int b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Ler novamente");
            }
            Console.WriteLine("Digite terceiro valor maior que 0");
            int c = int.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Ler novamente");
            }
            double menorValor = Math.Min(a, Math.Min(b, c));
            double maiorValor = Math.Max(a, Math.Max(b, c));
            Console.WriteLine("O menor valor é: " + menorValor);
            Console.WriteLine($"O maior valor é: {maiorValor}");
            Console.WriteLine($"Menor valor multiplicado pelo maior: {menorValor * maiorValor}");
            Console.WriteLine($"Maior valor dividido pelo menor: {maiorValor / menorValor}");
        }
    }
}


