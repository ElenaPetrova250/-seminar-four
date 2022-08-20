// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write ("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());

int GetExpNum (int num)
{
    int count = 0;
    for (int i = 1; i<=numberB; i++);
    {
        count = numberA*numberB;
    }
    return count;
}

Console.WriteLine (GetExpNum (num));