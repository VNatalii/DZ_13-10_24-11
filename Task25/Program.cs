// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Result(int num1, int num2)
{
    int res = 1;

    for (int i = 1; i <= num2; i++)
    {
        res = res * num1;
    }
    return res;
}


Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа a");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0)
{
    Console.WriteLine($"Введена не верная степень числа");
}

else 
{
    int result = Result(a, b);
    Console.WriteLine($"Число {a} в степени {b} равно {result}");
}


