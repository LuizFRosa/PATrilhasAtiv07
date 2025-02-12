using System;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        int[,] matriz = new int[3, 3];

        int soma = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = random.Next(1, 101);
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("A matriz é: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        
         int maiorValor = matriz[0, 0]; 

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] > maiorValor)
                {
                    maiorValor = matriz[i, j]; 
                }
            }
        }

        Console.WriteLine("\nO maior valor da matriz é: " + maiorValor);

        Console.WriteLine("\nClique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
