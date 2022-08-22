/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве. */
int size = int.Parse(Console.ReadLine());
int[] number = new int [size];

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++ )
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (array[i] % 2 == 1)
        {
            count++;
        }
    }
    return count;
}

FillArray(number, 100, 1000);
WriteArray(number);
Console.WriteLine();

int count = Positive(number);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");
