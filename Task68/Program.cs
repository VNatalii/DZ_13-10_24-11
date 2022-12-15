// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akker(int m, int n)
{

    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akker(m - 1, 1);
    if (m > 0 && n > 0) return Akker(m - 1, Akker(m, n - 1));
    return 0;
}


Console.Write("Задайте число m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int akker = Akker(m1,n1);
Console.Write($"функции Аккермана равна {akker} ");

