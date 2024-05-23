/*35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".

Meu código:*/
using System;
namespace Exercicio35
{
    public class Exercicio35
    {
        public static void Main()
        {
            int contador = 0;

            while (contador < 100)
            {
                contador++;
                if (contador % 10 == 0)
                {
                    Console.WriteLine("É multiplo de 10");
                }

                Console.WriteLine(contador);
            }
        }
    }
}


