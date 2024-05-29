/*39) Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, e se é positivo ou negativo. 
O programa só deve parar de rodar quando o usuário responder "S" na seguinte
pergunta, "Deseja encerrar o programa?" .

Meu código:*/

using System;

namespace Exercicio39
{
    public class Exercicio39
    {
        public static void Main()
        {

            char resposta;
            do
            {
                Console.WriteLine("Digite um número:");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0 && num > 0)
                {
                    Console.WriteLine($"{num} é um número par.");
                    if (num > 0)
                    {
                        Console.WriteLine($" {num} número positivo");
                    }

                    else
                    {
                        Console.WriteLine($"{num} número negativo");
                    }

                }
                else
                {
                    Console.WriteLine($"{num} é um número impar.");

                    if (num > 0)
                    {
                        Console.WriteLine($" {num} é um número positivo");
                    }
                    else
                    {
                        Console.WriteLine($"{num} é um número negativo");
                    }
                }
                Console.WriteLine("Deseja encerrar o programa?" + "S/N");
                resposta = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (resposta != 's');
        }
    }
}

