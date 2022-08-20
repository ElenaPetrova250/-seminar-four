// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = int.Parse(Console.ReadLine());

int SumNumber (int number)
{
    int count = Convert.ToString(number).Length;
    count = 0;
    result = 0;
    {
        for (int i = 0; i < count; i++)
        count = number - number % 10;
        result +=
        number = number/10;
    }
    return result;
}
int SumNumber = SumNumber (number);
Console.WriteLine("Сумма цифр с учетом: " + SumNumber);