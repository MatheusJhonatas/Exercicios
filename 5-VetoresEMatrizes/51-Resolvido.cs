/*51) Fazer um programa para ler uma quantidade N de alunos. 

Ler a nota de cada um dos N alunos e calcular a média aritmética das notas. 

Contar quantos alunos estão com a nota acima de 7.0.
Obs.: 
Se nenhum aluno tirou nota
acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.*/

using System;

namespace Exercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal notaAluno = 0;
            decimal somaNotas = 0;
            int alunosAcimaSete = 0;
            Console.WriteLine("Colégio Tenente General Gaspar de Godoi Colaço");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Quantos alunos tem na aula de Matematica?");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            decimal[] somaAritmetica = new decimal[quantidadeAlunos];
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine($"Digite a nota do Aluno {1 + i}");
                notaAluno = decimal.Parse(Console.ReadLine());
                somaNotas += notaAluno;
                if (notaAluno > 7)
                {
                    alunosAcimaSete++;

                }

            }

            decimal media = somaNotas / quantidadeAlunos;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Média arimtmetica dos alunos {media} ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"({alunosAcimaSete}) Alunos com notas acima de 7");
            Console.WriteLine("----------------------------------------------");
            if (notaAluno <= 5)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5");

            }
        }
    }
}