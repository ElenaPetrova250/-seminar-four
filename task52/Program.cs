// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] arrayWhole = new int[m, n];
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);
CreateArrayDouble(array);

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
         for (int j = 0; j < n; j++)
         {
            array[i, j] = new Random().NextDouble() * 20 - 10;
         }
    }
}

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += arrayWhole[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}
int[,] TransformationArrayWhole (double[,] array)
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

void WriteArrayInt (int[,] arrayWhole)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arrayWhole[i, j] + " ");
        }
        Console.WriteLine();
    }
}