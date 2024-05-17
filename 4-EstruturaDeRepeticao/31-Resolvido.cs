/*31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar.
Exiba
Ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos.
Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.*/
using System;

class Program
{
    static void Main()
    {
        // Inicializar as variáveis para armazenar as somas
        int somaPares = 0;
        int somaImpares = 0;

        // Loop para ler os números até que um número negativo seja inserido
        while (true)
        {
            Console.Write("Digite um número (negativo para encerrar): ");
            string input = Console.ReadLine();

            // Converter a entrada para um número inteiro
            if (int.TryParse(input, out int numero))
            {

                if (numero < 0)
                    break;

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine($"O número {numero} é ímpar.");
                    somaImpares += numero;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }
        Console.WriteLine($"Soma dos números pares: {somaPares}");
        Console.WriteLine($"Soma dos números ímpares: {somaImpares}");
    }
}