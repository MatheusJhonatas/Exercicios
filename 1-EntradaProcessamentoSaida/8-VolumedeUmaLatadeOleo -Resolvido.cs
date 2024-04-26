/*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:

V = 3.14159 * R * R * A
Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

MEU CÓDIGO:*/
using System;

namespace Volume_lata_oleo
{
    public class CalculoVolumelata
    {
        static void Main()
        {
            var pi = 3.14159;
            var r = 5.0;
            var a = 10.0;
            var v = pi * r * r * a;
            Console.WriteLine($"O valor do volume de uma lata de óleo e:{v} ");
        }
    }
}

/*Código chat gpt,

using System;

class Program
{
    static void Main()
    {
        double pi = 3.14159;

        // Defina o raio e a altura da lata de óleo
        double raio = 5.0; // substitua pelo valor do raio da lata em unidades de sua escolha
        double altura = 10.0; // substitua pelo valor da altura da lata em unidades de sua escolha

        // Calcula o volume da lata de óleo usando a fórmula fornecida
        double volume = pi * raio * raio * altura;

        // Exibe o resultado
        Console.WriteLine("O volume da lata de óleo é: " + volume);
    }
}*/
