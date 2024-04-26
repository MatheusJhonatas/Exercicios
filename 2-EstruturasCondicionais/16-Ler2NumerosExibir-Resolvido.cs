/*Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número. 
Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

Meu código: */
using System;
namespace Exercicio16
{
    class Programa
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + " É maior que o " + numero2);
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine(numero1 + " É menor que o " + numero2);
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais: " + numero1 + " e " + numero2);
            }

        }
    }
}

/*Código do Chatgpt: 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 == numero2)
        {
            Console.WriteLine("Os números são iguais: " + numero1);
        }
        else
        {
            int maior = Math.Max(numero1, numero2);
            int menor = Math.Min(numero1, numero2);

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
        }
    }
}*/
