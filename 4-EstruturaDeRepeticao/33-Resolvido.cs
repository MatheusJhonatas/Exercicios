/*33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova.
 O número de alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.

Meu código:*/

using System;
namespace Exercicio33
{
    public class Program
    {
        public static void Main()
        {
            double somaNotas = 0;
            int contadorAlunos = 0;

            Console.WriteLine("Digite a notas dos alunos ou -1 para encerrar");
            while (true)
            {

                Console.WriteLine("Digite a nota do {0}° aluno", contadorAlunos + 1);
                double nota = double.Parse(Console.ReadLine());
                if (nota == -1)
                {
                    break;
                }
                somaNotas += nota;
                contadorAlunos++;
                Console.WriteLine("Número de matricula do Aluno ");
                string matricula = Console.ReadLine();
                if (matricula == "-1")
                {
                    break;
                }
            }
            if (contadorAlunos > 0)
            {
                double media = somaNotas / contadorAlunos;
                Console.WriteLine("A média dos alunos é: {0}", media);
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi inserida.");
            }
        }

    }
}
