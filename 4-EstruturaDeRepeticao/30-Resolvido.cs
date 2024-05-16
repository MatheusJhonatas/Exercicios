/*30) Faça um programa para imprimir uma tabuada.*/

using System;
using System.Runtime.InteropServices;
namespace Exercicios
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Qual tabuada você quer?");
            int tabu = int.Parse(Console.ReadLine());

            for (var i = 0; i <= 10; i++)
            {
                int resultado = i * tabu;
                Console.WriteLine($"{i} x {tabu} = {resultado}");
            }

        }
    }
}

