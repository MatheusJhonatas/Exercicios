/*Fazer um programa ler um vetor de inteiros e positivos e 
imprimir quantas vezes aparece o número 1, 3 e 4, nesta
ordem. 

O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1.
*/
using System;

public class Program
{
    public static void Main()
    {
        int[] vetor = new int[100];

        int option = 0, numero = 0, count1 = 0, count3 = 0, count4 = 0;
        Console.WriteLine("Digite até 100 números inteiros e positivos: \n Digite -1 para sair");
        do
        {

            numero = int.Parse(Console.ReadLine());
            if (numero == 1)
            {
                count1++;
            }
            else if (numero == 3)
            {
                count3++;
            }
            else if (numero == 4)
            {
                count4++;
            }
        } while (numero != -1);



        Console.WriteLine("Quantidade de vezes que o número 1 aparece: " + count1);
        Console.WriteLine("Quantidade de vezes que o número 3 aparece: " + count3);
        Console.WriteLine("Quantidade de vezes que o número 4 aparece: " + count4);
    }
}
