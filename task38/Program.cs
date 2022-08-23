// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arrayNumbers = new double[10];
for (int i = 0; i < arrayNumbers.Length; i++ )
{
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
}

double maxNumb = arrayNumbers[0];
double minNumb = arrayNumbers[0];

for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumb < arrayNumbers[i])
    {
        maxNumb = arrayNumbers[i];
    }
    if (minNumb > arrayNumbers[i])
    {
        minNumb = arrayNumbers[i];
    }
}

double decision = maxNumb - minNumb;
Console.WriteLine($"\nразница между между максимальным ({maxNumb}) и минимальным({minNumb}) элементами: {decision}");