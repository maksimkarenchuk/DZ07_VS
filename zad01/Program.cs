// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


        
        void PrintArray(Double[,] table)
            {
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i,j] + "\t" );
                        }
                    Console.WriteLine();
                }
            }

        Double[,] FillArray (int m, int n)
            {
                Double[,] array = new Double[m,n];
                for (int i=0;i<m;i++)
                    {
                        for (int j=0;j<n;j++)
                        array[i,j] = Math.Round(new Random().Next(-10,10)+new Random().NextDouble(), 1);
                            
                    }
                return array;
            }
        Console.Write ("Введите количество строк двумерного массива ");
        int m = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите количество стобцов двумерного массива ");
        int n = Convert.ToInt32 (Console.ReadLine());       
        Double[,] mas = FillArray(m,n);
        PrintArray(mas);
       
