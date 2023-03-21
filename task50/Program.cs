// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите позицию строки:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] GetRandomarray(int rows, int columns)
{
  int[,] array = new int[rows, columns];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Random.Shared.Next(10, 100);
    }
   
  }
  return array;
}

void Printmatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void GetNumberInArray(int[,] array)
{
  if (a > array.GetLength(0) || b > array.GetLength(1) )
  {
    Console.WriteLine("такого числа в массиве нет");
  }
  else
  {
    Console.WriteLine($"под этой позицией число :  {array[a-1, b-1]}");
  }
}

int[,] myarray = GetRandomarray(4, 5);
Printmatrix(myarray);
Console.WriteLine();
GetNumberInArray(myarray);

