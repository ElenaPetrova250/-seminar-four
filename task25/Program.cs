// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write ("Введите число A: ");
int numberA = int.Parse(Console.WriteLine());
Console.Write ("Введите число B: ");
int numberB = int.Parse(Console.WriteLine());
int result = int.Parse(Console.ReadLine());

int GetExpNum (int result);
{
result = 1;
for(int i=1; i <= numberB; i++)
    {
        result = result*numberA;
    }
    return result;
}

Console.WriteLine (GetExpNum (result));