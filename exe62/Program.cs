/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int n = 4;
int[,] spiralArrray = new int[n, n];
   
    int temp  = 1;
    int i = 0;
    int j = 0;
  
while (temp <= spiralArrray.GetLength(0) * spiralArrray.GetLength(1))
{
  spiralArrray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralArrray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralArrray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralArrray.GetLength(1) - 1)
    j--;
  else
    i--;
}
PrintArray(spiralArrray);

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

