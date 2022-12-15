// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNamber(int num1, int num2)
{

    if (num1 > num2) return 0;
    return num2 + SumNamber(num1, num2 - 1);

}


Console.Write("Задайте промежуток от N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("до M: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
{
    int sumNamber = SumNamber(m, n);
    Console.WriteLine($"сумму натуральных элементов в промежутке от {n} до {m} = {sumNamber}");
}

else if (n < m)
{
    int sumNamber = SumNamber(n, m);
    Console.WriteLine($"сумму натуральных элементов в промежутке от {n} до {m} = {sumNamber}");
}

else if (n == m)
{
    Console.WriteLine($"Введен не верный промежуток");
}

