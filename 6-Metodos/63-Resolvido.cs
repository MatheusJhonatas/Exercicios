/*Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O
método deverá receber um número inteiro (n) e deverá retornar a mensagem “PAR” ou “ÍMPAR”.*/

using System;

namespace ExerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            Verifica();
        }

        public static void Verifica()
        {
            char encerrar = 'n';
            do
            {
                Console.WriteLine("Digite um número para verificar se é IMPAR ou PAR.");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} é um número PAR");
                }
                else
                {
                    Console.WriteLine($"{number} é um número IMPAR");
                }
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                encerrar = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (encerrar != 'S');
        }
    }
}