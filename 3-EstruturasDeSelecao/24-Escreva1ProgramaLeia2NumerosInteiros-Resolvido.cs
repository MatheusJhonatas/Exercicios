/*24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
realizar:
1 – Verificar se um dos números lidos é ou não múltiplo do outro
2 – Verificar se os dois números lidos são pares
3 – Verificar se a média dos dois números é maior ou igual a 7.
4 – Sair

Meu  código:*/
using System;
using System.Diagnostics;

namespace Exercicio24
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número inteiro");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Vamos para o menu de verificações: ");
            Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 – Verificar se os dois números lidos são pares");
            Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7.");
            Console.WriteLine("4 – Sair");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    if (valor1 % valor2 == 0)
                    {
                        Console.WriteLine($"{valor1} é múltiplo de {valor2}.");
                    }
                    else
                    {
                        Console.WriteLine($"{valor1} não é múltiplo de {valor2}.");
                    }
                    break;
                case 2:
                    if (valor1 / 2 == 0 && valor2 / 2 == 0)
                    {
                        Console.WriteLine($"Pelo menos um dos números ({valor1} ou {valor2}) não é par.");
                    }
                    else
                    {
                        Console.WriteLine("Ambos " + valor1 + " e " + valor2 + " são pares");
                        ;
                    }
                    break;
                case 3:
                    if (valor1 + valor2 / 2 >= 7)
                    {
                        Console.WriteLine($"A média dos números {valor1} e {valor2} e é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine($"A média dos números {valor1} e {valor2}, NÃO é maior ou igual a 7.");
                    }
                    break;
                case 4: Console.WriteLine("Fechando o programa..."); Thread.Sleep(1000); System.Environment.Exit(4); break;
                default: Main(); break;
            }

        }
    }
}




