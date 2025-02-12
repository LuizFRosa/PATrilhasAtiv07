using System;

class Program
{
    public static void Main()
    {
        
        decimal[,] matriz = new decimal[2, 2]
        {
            { 5.5m, 7.2m },
            { 3.3m, 9.8m }
        };

        decimal soma = 0;
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);

       
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
        }

       
        decimal media = soma / totalElementos;

        
        Console.WriteLine("A matriz é: ");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        
        Console.WriteLine("\nA média dos valores da matriz é: "+ media);

        Console.WriteLine("\nClique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
