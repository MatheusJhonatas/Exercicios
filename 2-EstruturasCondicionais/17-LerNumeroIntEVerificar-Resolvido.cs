/*Escreva um programa que leia um número inteiro. Verificar por meio de 

condição se o valor fornecido está na faixa entre 0 (zero) e 9 (nove). 
Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
Caso contrário, apresentar a mensagem “valor inválido”.

Meu código:*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 >= 0 && number1 <= 9)
        {
            Console.WriteLine("valor valido");
        }
        else
        {
            Console.WriteLine("Valor Invalido");
        }
    }
}

/*Código do chat gpt:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");
        int numero;

        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}*/
