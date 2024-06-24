/*55) Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco.
Imprimir também a quantidade de espaços em branco da frase

Meu codigo*/
using System;

namespace Exercicio55
{
    public class Exercicio
    {
        public static void Main()
        {
            Console.WriteLine("Digite uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();
            string fraseSemEspacos = frase.Replace(" ", "");

            Console.WriteLine($"Frase sem os espaços em branco: {fraseSemEspacos}");
        }
    }
}