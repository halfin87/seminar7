// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

double [,] newarray(int rows, int columns)
{
  double [,] array = new double [rows, columns];
  {
    for (int i = 0; i < array.GetLength(0); i ++)
    {
     for (int j = 0; j < array.GetLength(1); j ++) 
     {
      array[i,j] = Random.Shared.NextDouble() * 10 ;
     }
    }
  }
  return array;
}

void Printmatrix (double [,] array)
{
 for (int i = 0; i < array.GetLength(0); i ++)
    {
     for (int j = 0; j < array.GetLength(1); j ++)
     {
      Console.WriteLine(array[i,j] + " ");
     }
     Console.WriteLine();
    } 
    
}

double [,] myarray = newarray (3, 4);
Printmatrix (myarray);
