/*Escreva um programa que leia dois números
 e apresente a diferença do maior para o menor.


Meu código: */

using System;

namespace Exercicio_15
{
    public class diferencaNumeros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            int diferencaNumeros;
            if (primeiroNumero >= segundoNumero)
            {
                diferencaNumeros = primeiroNumero - segundoNumero;
                Console.WriteLine("A diferença do maior para o menor é: " + diferencaNumeros);
            }
            else if (segundoNumero >= primeiroNumero)
            {
                diferencaNumeros = segundoNumero - primeiroNumero;
                Console.WriteLine("A diferença do maior para o menor é: " + diferencaNumeros);

            }
            else { Console.WriteLine("Os números são iguais. "); };

        }
    }
}


/*Código do chat gpt:
using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int diferenca = CalcularDiferenca(numero1, numero2);
        
        Console.WriteLine($"A diferença entre o maior e o menor número é: {diferenca}");
    }

    public static int CalcularDiferenca(int a, int b) {
        int maior = Math.Max(a, b);
        int menor = Math.Min(a, b);
        int diferenca = maior - menor;
        return diferenca;
    }
}*/

