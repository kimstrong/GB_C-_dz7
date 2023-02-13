// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
int m = 3;
int n = 4;
double[,] matrix = new double[m, n];
void PrintArray(double[,] array)
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
Random x = new Random(); 
int p = x.Next();
void FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(x.Next(-100, 100)/10.0);
        }
}
FillArray(matrix);
PrintArray(matrix);


