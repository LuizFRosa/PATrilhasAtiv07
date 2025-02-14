using System;

class Program
{
    public static void Main()
    {
        int[,] matriz = new int[10, 10];

        int valor = 1;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = valor;
                valor++;
            }
        }

        Console.WriteLine("A matriz é: ");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n(Matriz sem os elementos da diagonal principal): ");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i != j) // Ignora os elementos da diagonal principal
                {
                    Console.Write(matriz[i, j] + " ");
                }
                else
                {
                    Console.Write("   "); // Adiciona espaços no lugar da diagonal
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nClique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
