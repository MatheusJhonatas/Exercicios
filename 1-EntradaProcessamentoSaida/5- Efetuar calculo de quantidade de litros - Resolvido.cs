/*Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem,

 utilizando um automóvel que faz 12 Km por litro.

 Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.


Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.


Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
fórmula: LITROS_USADOS = DISTANCIA / 12.

 O programa deve apresentar os valores da velocidade média,
tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.

MEU CÓDIGO:*/
using System;

namespace QuantidadedeLitros
{
    public class QuantidadedeLitros
    {
        static void Main()
        {
            var car = 12;

            Console.WriteLine("Quanto tempo gastou na viagem?");
            double tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite agora uma velocidade média, durante sua viagem.");
            double velo_media = double.Parse(Console.ReadLine());

            double distancia_percorrida = tempo * velo_media;

            Console.WriteLine($"Distância percorrida é: {distancia_percorrida}");

            double litros_usados = distancia_percorrida / 12;

            Console.WriteLine($"Quantidade de litros usado foi: {litros_usados}");
        }
    }
}

/*CÓDIGO DO CHAT GPT:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o tempo gasto na viagem (em horas): ");
        double tempo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a velocidade média (em km/h): ");
        double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

        double distancia = tempo * velocidadeMedia; // Calcula a distância percorrida

        double litrosUsados = distancia / 12; // Calcula a quantidade de litros utilizada

        Console.WriteLine($"Velocidade média: {velocidadeMedia} km/h");
        Console.WriteLine($"Tempo gasto: {tempo} horas");
        Console.WriteLine($"Distância percorrida: {distancia} km");
        Console.WriteLine($"Quantidade de litros utilizada: {litrosUsados} litros");
    }
}
