// Дан целочисленный массив. Найти среднее арифметическое 
//каждого из столбцов.

Console.Write("Введите m: ");
Int32 m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
Int32 n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

Int32[,] array = new Int32[m, n];

Create2DArray(array);

WriteArray(array);

Console.WriteLine();

void Create2DArray(Int32[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

void WriteArray (Int32[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Int32 alignNumber = Convert.ToInt32(array[i, j]);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}


Int32[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  Int32 arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = arithmeticMean / m;
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (Int32[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}