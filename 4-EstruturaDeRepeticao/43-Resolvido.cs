/*43) Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. O monge, necessitando
de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com grãos de trigo dispostos em um
tabuleiro de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e os quadros
subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho barato e pediu que o serviço fosse
executado, sem se dar conta de que seria impossível efetuar o pagamento. Faça um programa para calcular o
número de grãos que o monge esperava receber.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Número de quadrados em um tabuleiro de xadrez
        int numeroQuadrados = 64;

        // Número de grãos no primeiro quadrado
        ulong numeroGraos = 1;


        for (int i = 2; i <= numeroQuadrados; i++)
        {
            // Multiplicando o número de grãos no quadrado anterior por 2 para obter o número de grãos neste quadrado
            numeroGraos += (ulong)Math.Pow(2, i - 1);
        }

        Console.WriteLine("Número total de grãos: " + numeroGraos);
    }
}
