/*42) Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO).
Meu código:*/

using System;
using System.Globalization;

namespace Exercicio42
{
    public class Exercicio42
    {
        public static void Main()
        {
            double maior = double.MinValue;
            double menor = double.MaxValue;
            while (true)
            {
                Console.WriteLine("Digite primeiro número: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite segundo número: ");
                int number2 = int.Parse(Console.ReadLine());
                if (number1 == 0 || number2 == 0)
                {
                    break;
                }
                if (number1 > number2)
                {
                    Console.WriteLine($"Primeiro número ({number1}) é maior que o segundo número({number2}).");
                }
                else if (number2 > number1)
                {
                    Console.WriteLine($"Segundo número ({number2}) é maior que primeiro número ({number1}).");
                }
            }

        }
    }
}