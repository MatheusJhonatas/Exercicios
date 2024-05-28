/*38) Faça um programa que leia as variáveis C e N,
respectivamente código e número de horas trabalhadas de um
operário. 
E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. 

Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E,

caso contrário zerar tal variável. 

A hora excedente de trabalho vale R$ 20,00. 

No final do processamento imprimir o salário total e o salário excedente. 

O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
programa?".

Meu código:*/

using System;


namespace Exercicio38
{
    public class Program
    {
        public static void Main()
        {
            char encerrar = 'N';
            do
            {
                Console.WriteLine("Digite o código do Funcionário: ");
                string c = Console.ReadLine();
                Console.WriteLine($"Digite o número de horas trabalhadas do operário {c}");
                decimal n = decimal.Parse(Console.ReadLine());
                decimal salario;
                decimal salarioExcedentes = 0;
                if (n > 50)
                {
                    decimal horasExcedentes = n - 50;
                    salarioExcedentes = horasExcedentes * 20;
                    salario = 50 * 10.0m + salarioExcedentes;
                }
                else
                {
                    salario = n * 10.0m;
                }

                Console.WriteLine($"Seu salário é: {salario}");
                Console.WriteLine($"Salário excedente: R$ {salarioExcedentes}");
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                encerrar = char.ToUpper(Console.ReadKey().KeyChar);

                Console.WriteLine();
            }
            while (encerrar != 'S');
        }

    }
}
