
/*50) Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número sorteado) tente acertar. 

Caso não acerte, o programa deve imprimir uma mensagem informando se o número
sorteado é maior ou menor que a tentativa feita. 

Ao acertar o número, o programa deve imprimir a quantidade de tentativas feitas.*/

using System;
namespace ExercicioOOP
{
    public class Program
    {
        public static void Main()
        {

            bool continuar = true;
            while (continuar)
            {
                int tentativas = 0;
                Console.WriteLine("---- SORTEADOR DE NÚMEROS ----");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Digite um número de 0 há 100: ");

                int numberResultado = int.Parse(Console.ReadLine());
                tentativas++;
                Random random = new Random();
                int numberSorteado = random.Next(1, 101);
                if (numberResultado > 100)
                {
                    Console.WriteLine("Número maior que o esperado, reiniciei o programa ; )");
                    Thread.Sleep(4000);
                    System.Environment.Exit(0);
                }


                if (numberSorteado == numberResultado)
                {
                    Console.WriteLine("Carregando resultado ... ");
                    Thread.Sleep(4000);
                    Console.WriteLine("Você Acertou :)");

                    Console.WriteLine($"{tentativas} tentativas");
                }
                else
                {
                    Console.WriteLine("Carregando resultado ... ");
                    Thread.Sleep(4000);
                    Console.WriteLine("Você errou!");

                }
                Console.WriteLine($"Número sorteado: {numberSorteado}");

                Console.WriteLine("Deseja sair? Digite 1 para sair e 2 para continuar.");
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    Console.WriteLine("Saindo ...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}