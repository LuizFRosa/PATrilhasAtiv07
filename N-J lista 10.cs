using System;

class Program
{
    public static void Main()
    {
        string[] Loja = { "Mercado Livre", "Magalu", "Lojas Renner", "Carrefour", "Leroy Merlin", "Ponto Frio", "Extra", "Amazon", "Casas Bahia", "Ricardo Eletro" };
        string[] Produto = { "Fritadeira Elétrica", "Smartphone", "Ar-Condicionado", "Máquina de Lavar", "Notebook", "Cadeira Gamer", "Televisão", "Smartwatch" };
        double[,] preco = new double[10, 8]; 
        Random rand = new Random(); // Para preencher a matriz com valores aleatórios
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                preco[i, j] = rand.Next(50, 171);
            }
            Console.WriteLine();
        }

        Console.WriteLine("As Relações de produtos e lojas com preços de até R$ 120,00:");
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (preco[i, j] <= 120)
                {
                    Console.WriteLine(Loja[i] + " - " + Produto[j] + " - R$ " + preco[i, j].ToString("F2"));
                }
            }
        }
      
        Console.WriteLine("\nClique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
