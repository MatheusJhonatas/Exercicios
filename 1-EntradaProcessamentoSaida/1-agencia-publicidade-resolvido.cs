/*Agência de Publicidade 
Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram
inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em
2 vetores distintos. Faça um programa para que imprima o vetor que contém os nomes das candidatas aptas a
concorrer a uma vaga para a campanha milionária.
Resposta:*/
using System;

namespace Exercicios
{
    public class Exercicio1
    {
        public void exercicio1()
        {
            string[] nome = new string[20] { "Maria", "Joana", "Ana", "Celia", "Luana", "Gabriela", "Fabiana", "Josefa", "Gilvonete", "Mariana", "Bruna", "Gabriela", "geovana", "vanessa", "Rebeca", "Lorena", "Micheli", "Otavia", "Orlanda", "Thais" };

            int[] idade = new int[20] { 17, 18, 19, 12, 22, 20, 24, 26, 23, 28, 24, 25, 26, 27, 28, 22, 21, 23, 21, 24 };


            for (int i = 0; i < nome.Length; i++)
            {
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.WriteLine("As canditadas aptas a participarem são: " + nome[i]);
                }
            }

        }
    }
}