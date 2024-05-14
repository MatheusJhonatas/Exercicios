/*28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.

Meu código:*/
using System;

namespace Exercicio28
{
    public class Exercicio28
    {
        public static void Main()
        {
            //28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.
            Console.WriteLine("Os números impares entre 100 e 200 são: ");
            for (var i = 100; i <= 200; i++)
            {

                while (i >= 100 && i <= 200 && i % 2 != 0)
                {

                    Console.WriteLine(i);
                    i++;
                }

            }
        }
    }
}
