/*58) Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. 

Imprimir também o maior. 

A quantidade de números lidos será definida pelo usuário.*/

using System;

namespace Exercicio58
{
    public class Exercicio58
    {
        public static void Main()
        {

            try
            {
                Console.WriteLine("Quantos números quer digitar?");
                int n = int.Parse(Console.ReadLine());

                int[] numeros = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Digite o número {(i + 1)}  \n (Precisam ser positivos e inteiros)");
                    numeros[i] = int.Parse(Console.ReadLine());
                    if (numeros[i] < 0)
                    {
                        Console.WriteLine("Número inválido, digite novamente");
                        i--;
                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                }
                Console.WriteLine($"A média dos números digitados é: {numeros.Average()}");//o método Average() calcula a média dos números
                Console.WriteLine("O maior número digitado foi: " + numeros.Max());//o método MAX (), verifica o maior número digitado
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Erro, número não pode ser menor que 0. ");
                Console.WriteLine("Reiniciando...");
                Thread.Sleep(4500);
                Console.Clear();
                Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro, número não pode ser menor que 0. ");
                Console.WriteLine("Reiniciando...");
                Thread.Sleep(4500);
                Console.Clear();
                Main();
            }
        }
    }
}
