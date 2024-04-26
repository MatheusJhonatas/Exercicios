/*Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes entre eles. 


Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.
Meu Código */
using System;

namespace Numeros_Inteiros
{
    public class Numeros_Inteiros
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int primeiro_numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int Segundo_numero = Convert.ToInt32(Console.ReadLine());

            if (primeiro_numero == Segundo_numero)
            {
                Console.WriteLine("Os números são iguais");
            }
            else
            {
                Console.WriteLine("Os números não são iguais");
            }
            if (primeiro_numero > Segundo_numero)
            {
                Console.WriteLine("O primeiro Número é maior que o segundo");
            }
            else
            {
                Console.WriteLine("O segundo é maior que o primeiro");
            }
        }
    }
}

/*Código do chatgpt
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número inteiro:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("Igual");
        }
        else
        {
            Console.WriteLine("Não igual");
        }

        if (num1 > num2)
        {
            Console.WriteLine("Maior");
        }
        else
        {
            Console.WriteLine("Menor");
        }

        if (num1 >= num2)
        {
            Console.WriteLine("Maior ou igual");
        }
        else
        {
            Console.WriteLine("Menor ou igual");
        }
    }
}*/
