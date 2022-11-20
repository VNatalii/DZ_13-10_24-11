// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int num)
{
    int sum = 0;
    num = Math.Abs(num);

    for (int i = 1; (num / i) >= 1; i*=10)
    {
        sum = sum + num / i % 10;
    }
    return sum;
}

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(a);
Console.WriteLine($"Сумма цифр числа {a} равна {sumNumber}");
