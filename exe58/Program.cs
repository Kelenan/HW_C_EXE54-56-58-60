/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

Console.Write("Введите количество строк первого массива: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов первого массива: ");
int columns1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк второго массива: ");
int rows2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов второго массива: ");
int columns2 = int.Parse(Console.ReadLine() ?? "");

int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] array2 = GetArray(rows2, columns2, 0, 10);

PrintArray(array1);
Console.WriteLine();

PrintArray(array2);
Console.WriteLine();

int [,] array3 = new int[rows1, columns2];

MultiplyMatrix(array1, array2, array3);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(array3);

// метод произведения двух матриц
void MultiplyMatrix(int[,] array1, int[,] array2, int[,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      array3[i,j] = sum;
    }
  }
}



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
