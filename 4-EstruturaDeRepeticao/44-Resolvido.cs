/*44) Faça um programa que exiba as opções:
1 – Conversão de Graus Celsius em Graus Fahrenheit
2 – Conversão de Graus Fahrenheit em Graus Celsius
3 – Peso ideal do homem
4 – Peso ideal da mulher
O programa só deve encerrar quando o usuário digitar ´S´ para a pergunta “Deseja encerrar o programa?”
Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.*/

using System;
using System.ComponentModel.Design;

namespace ExerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            char resposta = 'N';
            do
            {
                Menu();
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Adiciona uma quebra de linha após a resposta
            } while (resposta != 'S');


        }

        public static void Menu()
        {
            Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
            Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
            Console.WriteLine("3 – Peso ideal do homem");
            Console.WriteLine("4 – Peso ideal da mulher");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: convertCemF(); break;
                case 2: convertFemC(); break;
                case 3: calcularPesoH(); break;
                case 4: calcularPesoM(); break;

            }
        }
        public static void convertCemF()
        {
            Console.WriteLine("Digite os graus em celsius:");
            decimal celsius = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Convertendo...");
            Thread.Sleep(3000);
            Console.WriteLine($"A temperatura em celsius: {celsius} é igual a {(celsius * 9 / 5) + 32} graus Fahrenheit.");
        }
        public static void convertFemC()
        {
            Console.WriteLine("Digite a temperatura em fahrenheit: ");
            decimal fahrenheit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Convertendo...");
            Thread.Sleep(3000);
            Console.WriteLine($"A temperatura em fahrenheit: {fahrenheit} é igual a {(fahrenheit - 32) * 5 / 9} graus Celsius.");
        }
        public static void calcularPesoH()
        {
            Console.Write("Digite a altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double pesoIdeal = altura * 100 - 100;
            Console.WriteLine($"O peso ideal para um homem com altura {altura}m é de {pesoIdeal}kg.");

            Console.Write("Digite o peso atual em kg: ");
            double pesoAtual = Convert.ToDouble(Console.ReadLine());
            if (pesoAtual > pesoIdeal)
                Console.WriteLine("Você está acima do peso ideal.");
            else if (pesoAtual < pesoIdeal)
                Console.WriteLine("Você está abaixo do peso ideal.");
            else
                Console.WriteLine("Você está no peso ideal.");
        }
        public static void calcularPesoM()
        {
            Console.Write("Digite a altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double pesoIdeal = altura * 100 - 110;
            Console.WriteLine($"O peso ideal para uma mulher com altura {altura}m é de {pesoIdeal}kg.");

            Console.Write("Digite o peso atual em kg: ");
            double pesoAtual = Convert.ToDouble(Console.ReadLine());
            if (pesoAtual > pesoIdeal)
                Console.WriteLine("Você está acima do peso ideal.");
            else if (pesoAtual < pesoIdeal)
                Console.WriteLine("Você está abaixo do peso ideal.");
            else
                Console.WriteLine("Você está no peso ideal.");

        }
    }
}
