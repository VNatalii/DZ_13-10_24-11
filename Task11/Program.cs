// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (num < 1000) Console.WriteLine($"Третья цифра этого числа {num = (num % 10)}");
else
{
    while (num > 1000)
    {
        num = num / 10;
    }

    Console.WriteLine($"Третья цифра этого числа {num = (num % 10)}");
}


