using System;

namespace Exercicio57
{
    public class Program
    {
        //57) Fazer um programa que leia uma frase e imprima somente as vogais.
        public static void Main()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            string vogais = "aeiouAEIOU";
            string resultado = "";
            foreach (char c in frase)
            {
                if (vogais.Contains(c))
                {
                    resultado += c;
                }
            }
            Console.WriteLine($"Na frase contem as seguintes vogais: {resultado}");
        }
    }
}
