/*Escreva um programa que leia um número inteiro e exiba o seu módulo.
O módulo de um número x é:

x se x é maior ou igual a zero
x * (-1) se x é menor que zero

Código do chat gpt: 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");
        
        // Lê o número fornecido pelo usuário
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcula o módulo do número
        int modulo = numero >= 0 ? numero : numero * (-1);

        // Exibe o módulo
        Console.WriteLine("O módulo do número é: " + modulo);
    }
}


meu código:*/
using System;
namespace Modulo
{
    public class Modulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("é maior ou igual a zero");
            }
            else if (number < 0)
            {
                Console.WriteLine(number * (-1));
            }


        }
    }
}