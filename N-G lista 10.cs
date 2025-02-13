using System;

	  class Program
  	{
	  	public static void Main(string[] args)
		  {
		  	int[,] matriz = {

                { 23, 87, 45, 12 },
                { 56, 78, 91, 34 },
                { 67, 10, 89, 42 },
                { 99, 31, 74, 55 }
            };
      		
			Console.WriteLine("Matriz 4x4:");
      		for (int i = 0; i < 4; i++)
      		  {
          		  for (int j = 0; j < 4; j++)
          		 {
              		 if (matriz[i, j] % 2 == 0) 
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("-\t"); 
                    }
        	 	}
            Console.WriteLine();
      		  }
      		Console.WriteLine("\nClique qualquer botão para encerrar...");
      		Console.ReadKey();	
	}	
}
