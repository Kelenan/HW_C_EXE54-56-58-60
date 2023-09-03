/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество уровней массива: ");
int level = int.Parse(Console.ReadLine() ?? "");

int[,,] array = GetArray(rows, colums, level, 10, 99);

PrintArray(array);

Console.WriteLine();



void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.WriteLine();
           for (int l = 0; l < inArray.GetLength(2); l++)
             {
            
            Console.Write($"{inArray[i, j, l]} ({i}, {j}, {l}) ");
             }
            
        }
        Console.WriteLine();
    }
}

int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
             {
                result[i, j, l] = new Random().Next(minValue, maxValue + 1);
                int element = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, element)) continue;
                result[i, j, l] = element;
             }
            
        }
    }
    return result;
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}