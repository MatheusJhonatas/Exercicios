/*Ler dois valores inteiros para as variáveis A e B, 

efetuar a troca dos valores de modo que a variável A passe a possuir o valor da variável B,

 e a variável B passe a possuir o valor da variável A. 


Apresentar os valores trocados.

Meu código*/
using System;

namespace Troca_de_valores
{
    public class Troca_de_valores
    {
        public static void Main()
        {
            int a, b, temp;
            Console.WriteLine("Digite um valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Valores antes das trocas: \"valor A: {a} \" e \"Valor B: {b}\" ");

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Valores depois das trocas: \"valor A: {a} \" e \"valor B: {b} \" ");
        }
    }
}

//Código CHAT GPT

/*using System;

class TrocaValores
{
    static void Main()
    {
        int A, B, temp;

        Console.WriteLine("Digite o valor de A: ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        B = int.Parse(Console.ReadLine());

        Console.WriteLine($"Valores antes da troca: A = {A}, B = {B}");

        // Troca usando uma variável temporária
        temp = A;
        A = B;
        B = temp;

        Console.WriteLine($"Valores depois da troca: A = {A}, B = {B}");
    }
}*/

