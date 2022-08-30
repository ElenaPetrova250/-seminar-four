/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет. */

Console.WriteLine("Введите размеры массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

CreateArray(array);
WriteArray(array);

int[,] array = new int[m, n];

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = int.Parse(new Random().Next(0,21));
        }
    }
}

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t  ");
            Console.WriteLine();
        }
    }
}


Console.WriteLine("Введите координаты");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a>m && b>n)
{
    Console.WriteLine("такого числа нет");
}
else
{
object c = array.GetValue(a,b);
Console.WriteLine(c);
}