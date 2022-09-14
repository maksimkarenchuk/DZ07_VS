// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


void PrintArray(int[,] table)
{
        for (int i = 0; i < table.GetLength(0); i++)
        {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
        }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                array[i, j] = new Random().Next(-10, 10);
        }
        return array;
}

void Position(int[,] array)
{
            Console.Write("Введите строу двумерного массива ");
            int poz1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите столбец двумерного массива ");
            int poz2 = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (poz1 < 0 | poz1 > array.GetLength(0)-1 | poz2 < 0 | poz2 > array.GetLength(1)-1)
                            {
                                Console.Write("Такого элемента нет в массиве");
                            }
                    else  Console.Write($"Значение в масиве "+ array [poz1, poz2]);

}

try
        {
        Console.Write("Введите количество строк двумерного массива ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество стобцов двумерного массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] mas = FillArray(m, n);
        PrintArray(mas);
        Position(mas);
        }
catch
        {
            Console.Write("Введите числа цифрами");
        }


