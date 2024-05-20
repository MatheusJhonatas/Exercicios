/*32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número entre 1 e 9: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0 && numero < 10)
        {
            int somaQuadrados = 0;
            int contador = 0;
            int numeroAtual = numero;

            while (contador < 20)
            {
                if (numeroAtual % 2 != 0)
                {
                    somaQuadrados += numeroAtual * numeroAtual;
                    contador++;
                }
                numeroAtual++;
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é: {somaQuadrados}");
        }
        else
        {
            Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 9.");
        }
    }
}
