using System;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        int[,] matriz = new int[4, 2];

        int soma = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matriz[i, j] = random.Next(1, 11);
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("A matriz é: ");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSoma de todos os valores da matriz: " + soma);

        Console.WriteLine("\nClique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
