// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
         array[i, j] = new Random().Next(1, 10);
   }
   return array;

}

void Summstolb(int[,] array)
{
   int[] summ = new int[array.GetLength(0)];
   for (int i = 0; i < array.GetLength(0); i++)
   {

      for (int j = 0; j < array.GetLength(1); j++)
      {
         summ[i] += array[j, i];

      }

   }

   foreach (double elem in summ)
   {

      Console.WriteLine(Math.Round(elem / array.GetLength(1), 2)); //вывод среднего для колонки
   }

}

Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
Summstolb(mas);
