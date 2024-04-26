Faça um programa que:
- Leia a cotação do dólar
- Leia um valor em dólares
- Converta esse valor para Real
- Mostre o resultado

using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a cotação do dólar:");
        decimal cotacao_dolar = decimal.Parse(Console.ReadLine() + "\n");
        Console.WriteLine("Digite o valor em dólar que precisa converter para REAL: ");
        decimal valor_dolar = decimal.Parse(Console.ReadLine() + "\n");
        decimal valor_real = cotacao_dolar * valor_dolar;
        Console.WriteLine(valor_real.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));


    }

}