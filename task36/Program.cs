// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите количество элементов массива: ");
int Elements = int.Parse(Console.ReadLine());

int RandomNumbers(int Elements, int min, int max)
{
    int[] randomNumbers = new int[Elements];
    int sumElements = 0;
    Console.Write("Ваш массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers =  RandomNumbers(Elements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");