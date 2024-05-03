/*Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é positivo ou negativo. 
Pare a execução do programa quando o usuário requisitar.

Meu código:*/
using System;

namespace Exercicio21
{
    public class Exercicio21
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Esse número é negativo");
            }
            else
            {
                Console.WriteLine("Esse número é positivo");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Quer continuar?");
            Console.WriteLine("Digite 1 para sair");
            Console.WriteLine("Digite 2 para continuar");
            Console.WriteLine("---------------------");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: System.Environment.Exit(1); break;
                case 2: Main(); break;
            }
        }
    }
}
