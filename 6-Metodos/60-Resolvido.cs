using System;
namespace Exercicio60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y:");
            int y = int.Parse(Console.ReadLine());

            int quadrante = VERIFICA_QUADRANTE(x, y);
            Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}");
        }

        static int VERIFICA_QUADRANTE(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0; // ponto está na origem (0, 0)
            }
        }
    }
}