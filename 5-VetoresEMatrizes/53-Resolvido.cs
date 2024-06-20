using System;

namespace Exercicios
{
    public class Program
    {
        public static void Main()
        {
            /*53) Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem os tempos registrados em cada volta.
             Fazer um programa para ler os tempos das N voltas, calcular e imprimir:
             i. melhor tempo;
             ii. a volta em que o melhor tempo ocorreu;
             iii. tempo médio das N voltas; */

            Console.WriteLine("Digite a quantidade de voltas: ");
            int voltas = int.Parse(Console.ReadLine());

            double[] tempo = new double[voltas];

            double MelhorTempo = 0;
            int VoltaMelhorTempo = 1;
            double TempoMedio = 0;
            //Console.Clear();
            for (int i = 0; i < voltas; i++)
            {

                Console.WriteLine($" Tempo da volta {i + 1}:");
                tempo[i] = double.Parse(Console.ReadLine());
                TempoMedio += tempo[i];
                MelhorTempo = tempo.Max();
                if (tempo[i] < MelhorTempo)
                {
                    MelhorTempo = tempo[i];
                    VoltaMelhorTempo = i + 1;
                }
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------RESULTADO---------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Melhor tempo entre as voltas é: " + MelhorTempo + "\n");

            Console.WriteLine($"Tempo médio das voltas: {TempoMedio / voltas}\n");

            Console.WriteLine($"A volta {VoltaMelhorTempo} teve o melhor tempo.\n ");
            Console.WriteLine("---------------------------------------");
        }
    }
}

