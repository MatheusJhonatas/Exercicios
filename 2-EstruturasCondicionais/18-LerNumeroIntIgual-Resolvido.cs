/*Escreva um programa que leia um número inteiro (variável CODIGO). 
Verificar se o código é igual a 1, igual a 2 ou
igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é
um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch)
Meu código: */

using System;
using System.Collections;
using System.Diagnostics;
namespace caneta
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número de 1 há 10: ");
            int Codigo = int.Parse(Console.ReadLine());

            switch (Codigo)
            {
                case 1: Console.WriteLine("Valor válido, " + "número um"); break;
                case 2: Console.WriteLine("Valor válido, " + "número dois"); break;
                case 3: Console.WriteLine("Valor válido, " + "número três"); break;
                default: Console.WriteLine("Valor Inválido"); break;
            }
        }

    }
}


/*Código do chat gpt:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número (1, 2 ou 3):");
        int CODIGO = Convert.ToInt32(Console.ReadLine());

        switch (CODIGO)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default:
                Console.WriteLine("Código inválido");
                break;
        }

        Console.ReadLine(); // Para manter a janela aberta até que o usuário pressione Enter
    }
}
*/