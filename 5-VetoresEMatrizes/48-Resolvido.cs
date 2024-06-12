/*48) Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. 

Foram inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. 

Tais informações foram armazenadas em 2 vetores distintos.
 
Faça um programa para imprimir o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] idade = new int[20] { 18, 19, 17, 16, 24, 25, 20, 18, 20, 22, 33, 19, 20, 32, 25, 24, 23, 26, 28, 20 }; //inicializando o vetor com 20 posições
        string[] nome = new string[20] { "Maria Vanessa", "Ana Beatriz", "Bruna Regina", "Maria Eduarda", "Taluane Cristina", "Maria Leticia", "Jessica", "Bianca nunes", "Eva Lovia", "Juliana Machado", "Carol Ruty", "Ruth Sabino", "Flavia Munsk", "Gilvonete Francisca", "Girleide Francisca", "Isabel Cristina", "Bruna Tavares", "Amanda Buschesque", "Aidra Felix", "Anna Cheery", };
        Console.WriteLine(" Candidatas aptas para participar do Concurso de Beleza:  \n");
        for (int i = 0; i < 20; i++)
        {
            if (idade[i] >= 18 && idade[i] <= 20)
            {
                Console.WriteLine("Nome:" + nome[i] + "  | " + " Idade: " + idade[i] + "\n");
            }
        }
    }
}