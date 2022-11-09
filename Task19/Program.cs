// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) Console.WriteLine($"Число {num} не является палиндромом");
else if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введено не верное число");
}

else if (num < 0) Console.WriteLine($"Число {num} не является палиндромом");

else
{
    int n1 = num / 10000 % 10;
    int n2 = num / 1000 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10;

    if (n1 == n5 && n2 == n4) Console.WriteLine($"Число {num} является палиндромом");
    else Console.WriteLine($"Число {num} не является палиндромом");
    
}




