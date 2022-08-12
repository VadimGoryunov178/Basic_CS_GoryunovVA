// Написать программу, которая обменивает элементы 
//первой строки и последней 



    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  
            const int n = 4, m = 4;    
            int[,] matrix = new int[n, m]; 
            int i, j, temp;   
            Console.WriteLine("Рандомный массив:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(100); 
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        
            for (j = 0; j < m; j++)
            {
                temp=matrix[0, j];
                matrix[0, j]=matrix[n - 1, j];
                matrix[n - 1, j] = temp;
            }
            Console.WriteLine("Массив после замены строк:");
        
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
                Console.Read();
        }
    }