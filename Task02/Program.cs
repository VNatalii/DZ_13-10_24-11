// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите число a ");
int numa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb > numa) Console.Write($"Число {numb} больше числа {numa}");
else if (numb < numa) Console.Write($"Число {numa} больше числа {numb}");
else Console.Write($"Число {numa} равно числу {numb}");

