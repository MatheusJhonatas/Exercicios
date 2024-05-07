/*23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
1 – Adição
2 – Subtração
3 – Multiplicação
4 – Divisão

Meu código:*/
using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
namespace Exercicio23
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("1 PARA Adição");
            Console.WriteLine("2 PARA Subtração");
            Console.WriteLine("3 PARA Multiplicação");
            Console.WriteLine("4 PARA Divisão");
            Console.WriteLine("0 PARA SAIR");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: adicao(); break;
                case 2: subtracao(); break;
                case 3: multiplicacao(); break;
                case 4: divisao(); break;

            }
            static void adicao()
            {
                Console.WriteLine("Digite um numero: ");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int v2 = int.Parse(Console.ReadLine());
                int soma = v1 + v2;
                Console.WriteLine($"A soma dos números é: {soma}");
                Main();
            }
            static void subtracao()
            {
                Console.WriteLine("Digite um numero: ");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int v2 = int.Parse(Console.ReadLine());
                int subtracao1 = v1 - v2;
                Console.WriteLine($"A subtração dos números é: {subtracao1}");
                Main();
            }
            static void multiplicacao()
            {
                Console.WriteLine("Digite um numero: ");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int v2 = int.Parse(Console.ReadLine());
                int multiplic1 = v1 * v2;
                Console.WriteLine($"A soma dos números é: {multiplic1}");
                Main();
            }
            static void divisao()
            {
                Console.WriteLine("Digite um numero: ");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int v2 = int.Parse(Console.ReadLine());
                int div = v1 / v2;
                Console.WriteLine($"A soma dos números é: {div}");
                Main();
            }
        }
    }
}

