using System;

class Program
{
    public static void Main()
    {
       int[,] matriz = {

		{1, 2, 3},
		{4, 5, 6},
		{7, 8, 9}

		};

    	Console.WriteLine("A matriz é: ");
		for (int i = 0; i < 3; i++) { 

			for (int j = 0; j < 3; j++) { 

				Console.Write(matriz [i, j] + " ");

			}
    			Console.WriteLine();
			}
    			Console.WriteLine("Clique qualquer botão para encerrar...");
        	Console.ReadKey();
    }
}
