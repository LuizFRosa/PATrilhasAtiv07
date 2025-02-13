using System;

	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[10, 10];
       		Random rand = new Random();
       		 
       		Console.WriteLine("Matriz 10x10:");
      		  for (int i = 0; i < 10; i++)
      		  {
        	    for (int j = 0; j < 10; j++)
         		{
                matriz[i, j] = rand.Next(1, 101);
                Console.Write(matriz[i, j].ToString().PadLeft(4));
         	     }
            Console.WriteLine();
        	   }
   
      		 int somaPrincipal = 0;
       		 for (int i = 0; i < 10; i++)
        	 {
          		  somaPrincipal += matriz[i, i];
       	      }
       		 double mediaPrincipal = somaPrincipal / 10.0;
       		 
       		int somaSecundaria = 0;
        	for (int i = 0; i < 10; i++)
       		{
          		  somaSecundaria += matriz[i, 9 - i];
       		 }
      		double mediaSecundaria = somaSecundaria / 10.0;

       		Console.WriteLine("\nSoma da diagonal principal: " + somaPrincipal);
          Console.WriteLine("Média da diagonal principal: " + mediaPrincipal);
       		Console.WriteLine("Soma da diagonal secundária: " + somaSecundaria);
        	Console.WriteLine("Média da diagonal secundária: " + mediaSecundaria);

          Console.WriteLine("\nClique qualquer botão para encerrar...");
      		Console.ReadKey();
		}
	}	
