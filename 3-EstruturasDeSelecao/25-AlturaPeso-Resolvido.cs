/*25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal,
utilizando as seguintes fórmulas: (h = altura)
- Para homens: (72.7*h) - 58
- Para mulheres: (62.1 *h) - 44.7

Meu código:
*/
using System;
using System.Diagnostics;

namespace Exercicio25
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Você é homem, ou mulher?");
            Console.WriteLine("Digite abaixo a opção correta");
            Console.WriteLine("1 - PARA MULHER");
            Console.WriteLine("2 - PARA HOMEM");
            Console.WriteLine("3 - PARA SAIR");
            Console.WriteLine("-----------------------------");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: woman(); break;
                case 2: man(); break;
                case 3: Console.WriteLine("Programa Encerrado...."); System.Environment.Exit(3); break;
                default: Console.WriteLine("Algo saiu do controle, tente novamente..."); break;
            }

        }
        public static void woman()
        {
            Console.WriteLine("Digite sua altura: ");
            float h = float.Parse(Console.ReadLine());
            double pesoIdeal = (62.1 * h) - 44.7;
            Console.WriteLine($"Seu peso ideal é: {pesoIdeal}");
        }
        public static void man()
        {
            Console.WriteLine("Digite sua altura: ");
            float h = float.Parse(Console.ReadLine());

            double pesoIdeal = (72.7 * h) - 58;
            Console.WriteLine("Seu peso ideal é: " + pesoIdeal);
        }

    }
}
