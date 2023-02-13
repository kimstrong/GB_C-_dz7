// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
int m = 3;
int n = 4;
int[,] matrix = new int[m, n];
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }

}
FillArray(matrix);
PrintArray(matrix);


Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += matrix[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"столбца № {i+1}: {arithmeticMean}");
}

// разобралась)
