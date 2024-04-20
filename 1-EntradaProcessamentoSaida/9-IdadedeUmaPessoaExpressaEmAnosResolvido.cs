/*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias

 e escreva a idade dessa pessoa expressa apenas em dias.

 Considerar ano com 365 dias e mês com 30 dias.

Meu código:*/
using System;
using Microsoft.VisualBasic;

namespace leitura_idade
{
    public class Leitura_idade
    {
        public static void Main()
        {
            Console.WriteLine("Digite a sua idade em anos: ");
            int idade_anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua idade em meses: ");
            int idade_meses = int.Parse(Console.ReadLine());

            // Calcula a idade em dias
            int idade_dias = (idade_anos * 365) + (idade_meses * 30);

            // Exibe o resultado
            Console.WriteLine("A idade total em dias é: " + idade_dias + " dias.");



        }
    }
}

/*Código chatgpt

using System;

class Program
{
    static void Main()
    {
        // Solicita as entradas de idade em anos, meses e dias
        Console.Write("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        // Calcula a idade em dias
        int idadeEmDias = (anos * 365) + (meses * 30) + dias;

        // Exibe o resultado
        Console.WriteLine("A idade total em dias é: " + idadeEmDias + " dias.");
    }
}*/
