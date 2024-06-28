/*59) Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente entre eles. 
Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro.
Exemplo: Digite 2 caracteres: j t O numero de caracteres entre eles é: 9*/

using System;

namespace Exercicio59
{
    public class Exercicio59
    {
        public static void Main()
        {
            Console.WriteLine("Digite 2 caracteres: ");
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            if (c1 < c2)
            {
                Console.WriteLine($"O número de caracteres entre eles é: {c2 - c1 - 1}");//-1 para não contar os próprios caracteres
            }
            else
            {
                Console.WriteLine("Erro: os caracteres não estão em ordem alfabética.");
            }

        }
    }
}