/*Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. 

O método deve
receber o valor do salário e o índice de reajuste.

Fiz o exercicio pensando em OOP: 
CÓDIGO DA PRIMEIRA CLASSE SALARIO:
using System;

namespace ExerciciosOOP
{
    public class Salario
    {
        public Pessoa funcionario { get; set; }
        public Salario(Pessoa fun)
        {
            this.funcionario = fun;
        }
        public void reajusteSalario()
        {

            Console.WriteLine($"Digite o valor do seu salario atual: {funcionario.Nome}");
            decimal salarioAtual = decimal.Parse(Console.ReadLine());
            if (salarioAtual <= 1000)
            {
                Console.WriteLine($"{funcionario.Nome} terá um reajuste de 20%.");
                decimal porcentagem = 20;
                decimal salarioNovo = 0;
                Console.Clear();
                Console.WriteLine("Carregando aumento...");
                Thread.Sleep(3000);
                Console.WriteLine("Digite ENTER para discubrir seu novo salário.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Aumento de: {salarioAtual * 20 / 100}  R$.");
                Thread.Sleep(3000);
                Console.WriteLine($"Seu novo salário é: {salarioAtual * 20 / 100 + salarioAtual} R$");
            }
            else if (salarioAtual <= 3000)
            {
                Console.WriteLine($"{funcionario.Nome} terá um reajuste de 10%.)");
                decimal porcentagem = 10;
                decimal salarioNovo = 0;
                Console.Clear();
                Console.WriteLine("Carregando aumento...");
                Thread.Sleep(3000);
                Console.WriteLine("Digite ENTER para discubrir seu novo salário.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Aumento de: {salarioAtual * 10 / 100}  R$.");
                Thread.Sleep(3000);
                Console.WriteLine($"Seu novo salário é: {salarioAtual * 10 / 100 + salarioAtual} R$");
            }
            else
            {
                Console.WriteLine($"{funcionario.Nome} terá um reajuste de 5%.");
                decimal porcentagem = 5;
                decimal salarioNovo = 0;
                Console.Clear();
                Console.WriteLine("Carregando aumento...");
                Thread.Sleep(3000);
                Console.WriteLine("Digite ENTER para discubrir seu novo salário.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Aumento de: {salarioAtual * 5 / 100}  R$.");
                Thread.Sleep(3000);
                Console.WriteLine($"Seu novo salário é: {salarioAtual * 5 / 100 + salarioAtual} R$");
            }
        }
    }
}

CLASSE PESSOA:
using System;

namespace ExerciciosOOP
{
    public class Pessoa
    {
        protected string nome;
        protected int idade;
        protected decimal peso;
        protected string sexo;
        protected int cpf;
        public int CPF { get { return cpf; } set { cpf = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public decimal Peso { get { return peso; } set { peso = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public Pessoa(string _nome, int _idade, string _sexo)
        {
            this.Nome = _nome;
            this.Idade = _idade;
            this.Sexo = _sexo;
        }
    }
}

pROGRAM

using System;

namespace ExerciciosOOP
{
    public class Program
    {
        public static void Main()
        {
            Pessoa a = new Pessoa("Ana Beatriz", 24, "f");
            Salario b = new Salario(a);
            b.reajusteSalario();
        }

    }
}
*/