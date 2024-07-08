/*Escreva um programa que deverá ter as seguintes opções:
1 - Carregar Vetor
2 - Listar Vetor
3 - Exibir apenas os números pares do vetor
4 - Exibir apenas os números ímpares do vetor
5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
7 - Sair
Deverá ser implementado um método para realizar cada uma das opções de 1 a 6.*/
using System;

namespace ExerciciosOOP
{
    public class Program
    {
        static int[] vetor;

        public static void Main()
        {

            Menu();
        }
        public static void Menu()
        {
            int option;
            do
            {
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor ");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção selecionada: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: CarregarVetor(); break;
                    case 2: ListarVetor(); break;
                    case 3: ExibirPares(); break;
                    case 4: ExibirImpares(); break;
                    case 5: ExibirParesQuantidade(); break;
                    case 6: ExibirImparesQuantidade(); break;
                    case 7: Console.WriteLine("Saindo ..."); Thread.Sleep(2500); break;
                    default: Menu(); break;
                }
            } while (option != 7);
        }
        public static void CarregarVetor()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: 1 - Carregar Vetor");
            Console.WriteLine("Carregando...");
            Thread.Sleep(3000);
            Console.WriteLine("Digite o tamanho do vetor que quer exibir:");
            int tamanho = int.Parse(Console.ReadLine());
            vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Carregando Vetor...");
            Thread.Sleep(2000);
            Console.WriteLine("Vetor carregado!!!!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        public static void ListarVetor()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: 2 - Listar Vetor");
            Console.WriteLine("Carregando...");
            Thread.Sleep(3000);
            if (vetor == null)
            {
                Console.WriteLine("Vetor não foi carregado");
                return;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Vetor: ");

            foreach (int item in vetor)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ExibirPares()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: 3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("Carregando...");
            Thread.Sleep(3000);
            if (vetor == null)
            {
                Console.WriteLine("Vetor não carregado.");
                Thread.Sleep(3000);
                return;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Números pares do vetor: ");
            foreach (var item in vetor)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }

            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ExibirImpares()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: 4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("Carregando...");
            Thread.Sleep(3000);
            if (vetor == null)
            {
                Console.WriteLine("Vetor Não carregado...");
                Thread.Sleep(3000);
                return;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Números impares do vetor: ");
            foreach (var item in vetor)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ExibirParesQuantidade()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: 5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
            Console.WriteLine("Carregando...");
            Thread.Sleep(3000);
            if (vetor == null)
            {
                Console.WriteLine("Vetor Não carregado...");
                Thread.Sleep(3000);
                return;
            }
            int count = 0;
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Número de pares nas posições impares: {count}");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ExibirImparesQuantidade()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: 6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
            Console.WriteLine("Carregando...");
            Thread.Sleep(3000);
            if (vetor == null)
            {
                Console.WriteLine("Vetor Não carregado...");
                Thread.Sleep(3000);
                return;
            }
            int count = 0;
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Número de impares nas posições pares: {count}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}


