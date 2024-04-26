Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit.
A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
Fahrenheit e a variável C representa é a temperatura em graus Celsius.

MEU CÓDIGO: 

using System;

namespace Temperatura
{
    public class Conversao_Temperatura
    {
        static void Main()
        {
            Console.WriteLine("Digite sua temperatura em CELSIUS: ");
            double temperatura_celsius = double.Parse(Console.ReadLine());

            double temperatura_fahrenheit = (9 * temperatura_celsius + 160) / 5;
            Console.WriteLine($"A conversão da sua temperatura para Fahrenheit é: {temperatura_fahrenheit}");
        }
    }
}

CÓDIGO CHATGPT:

using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a temperatura em graus Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");
    }
}

O F2 dentro das chaves indica que o valor de celsius será exibido com duas casas decimais (duas casas após o ponto decimal). Isso é útil para controlar a precisão do número exibido.

Então, quando você vê "A temperatura em Celsius é: {celsius:F2}°C", isso significa que o valor da variável celsius será inserido no lugar de {celsius:F2} na string, e será exibido com duas casas decimais, seguido de "°C" para indicar que é em graus Celsius.