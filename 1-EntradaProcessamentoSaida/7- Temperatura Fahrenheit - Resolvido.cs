//Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. 
//A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
//variável C é a temperatura em graus Celsius.*/v
using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário para inserir a temperatura em Fahrenheit
        Console.Write("Digite a temperatura em Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Converter Fahrenheit para Celsius usando a fórmula
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Apresentar o resultado
        Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}°C");
    }
}

