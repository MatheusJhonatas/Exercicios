/*46) Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. 
Ou seja, realizar a soma de todos dos resultados da multiplicação de x[i] por y[i].*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Calculo para determinar o produto escalar de dois vetores. ---\n");

        Console.WriteLine("Quantidade de números para cada vetores: \n");

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Digite os números do primeiro vetor:");
        int[] vetor1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n");
        Console.WriteLine("_____________________________________");
        Console.WriteLine("Digite os números do segundo vetor:");
        int[] vetor2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            vetor2[i] = int.Parse(Console.ReadLine());
        }
        if (vetor1.Length != vetor2.Length)
        {
            Console.WriteLine("Os vetores têm tamanhos diferentes. Não é possível calcular o produto escalar.");
            return;
        }
        int produtoEscalar = ProdutoEscalar(vetor1, vetor2);
        Console.WriteLine("\n");
        Console.WriteLine("_____________________________________");
        // Exibir o resultado
        Console.WriteLine("O produto escalar dos vetores é: " + produtoEscalar);
        Console.WriteLine("_____________________________________");
    }

    static int ProdutoEscalar(int[] x, int[] y)
    {
        int produtoEscalar = 0;

        // Iterar sobre os elementos dos vetores
        for (int i = 0; i < x.Length; i++)
        {
            // Multiplicar os elementos correspondentes e somar ao produto escalar
            produtoEscalar += x[i] * y[i];
        }

        return produtoEscalar;
    }

}


