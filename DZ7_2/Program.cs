// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

void FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
}
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите номер строки искомого числа: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого числа: ");
int colum = Convert.ToInt32(Console.ReadLine());
if (row >= m && colum >= n) 
{
    Console.WriteLine("Заданные параметры за пределами массива.");
}
else
{
    Console.WriteLine(matrix[row,colum]);
};

