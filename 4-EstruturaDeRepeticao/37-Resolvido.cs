/*37) Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as
seguintes opções:
1 – Adição
2 – Subtração
3 – Multiplicação
4 – Divisão
Informe a opção:
A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o
programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao
menu principal. Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o
programa.
Meu código:*/
using System;
using System.Security.AccessControl;

namespace Exercicio37
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("       CALCULADORA     ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Para SAIR");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Console.WriteLine("SAINDO..."); Thread.Sleep(4000); System.Environment.Exit(0); break;
                case 1: adicao(); break;
                case 2: subtracao(); break;
                case 3: divisao(); break;
                case 4: Multiplicacao(); break;
                default: Main(); break;
            }
        }
        public static void adicao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero para adição: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero para adição: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A soma de {v1} + {v2} = {v1 + v2}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (resposta == 'S')
            {
                Main();
            }
        }
        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero para multiplicação: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero para multiplicação: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A multipicação de {v1} x {v2} = {v1 * v2}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (resposta == 'S')
            {
                Main();
            }
        }
        public static void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero para subtração: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero para subtração: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A subtração de {v1} - {v2} = {v1 - v2}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (resposta == 'S')
            {
                Main();
            }
        }
        public static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero para divisão: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero para divisão: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A divisão de {v1} / {v2} = {v1 / v2}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (resposta == 'S')
            {
                Main();
            }
            else
            {
                Console.WriteLine("SAINDO...");
                System.Environment.Exit(0);
            }
        }
    }
}
