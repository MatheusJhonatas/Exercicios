/*Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método
recebe o valor da base e da altura de um triângulo.

Fórmulas: hipotenusa² = base² + altura²
base x altura
área = ----------------------
2*/

using System;
namespace Exercico62
{
    public class Program
    {

        static void Main()
        {
            Console.WriteLine("Digite o valor da base do triângulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triângulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);
            double area = CalcularArea(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");
            Console.WriteLine($"A área do triângulo é: {area}");
        }

        static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }

        static double CalcularArea(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }

}

