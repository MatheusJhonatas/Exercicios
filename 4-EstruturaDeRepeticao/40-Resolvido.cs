/*40) A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
altamente poluentes do meio ambiente. 

O índice de poluição aceitável varia de 0,05 até 0,25. 

Se o índice sobe para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades,

se o índice crescer para 0,4 as
industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades,

se o índice atingir 0,5 todos os grupos
devem ser notificados a paralisarem suas atividades. 

Faça um programa que leia o índice de poluição medido e emita a notificação adequada aos diferentes grupos de empresas.

O algoritmo só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".

Meu código:*/

using System;

namespace Exercicio40
{
    public class Industrias
    {
        public static void Main()
        {

            char encerrar = 'N';
            do
            {
                Console.WriteLine("Qual seu indice de poluição:");
                decimal indice = decimal.Parse(Console.ReadLine());
                if (indice >= 0.05m && indice < 0.3m)
                {
                    Console.WriteLine("Índice de poluição dentro do aceitável.");
                }
                else if (indice >= 0.3m && indice < 0.4m)
                {
                    Console.WriteLine("Atenção! Índice de poluição atingiu 0.3. Indústrias do 1º grupo devem suspender suas atividades.");
                }
                else if (indice >= 0.4m && indice < 0.5m)
                {
                    Console.WriteLine("Atenção! Índice de poluição atingiu 0.4. Indústrias do 1º e 2º grupo devem suspender suas atividades.");
                }
                else if (indice >= 0.5m)
                {
                    Console.WriteLine("Atenção! Índice de poluição atingiu 0.5. Todas as indústrias devem suspender suas atividades.");
                }
                else
                {
                    Console.WriteLine("Índice de poluição abaixo do aceitável.");
                }
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                encerrar = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (encerrar != 'S');
        }
    }
}