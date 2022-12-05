// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int[] CreateArrayRndInt (int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

int Count(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;

    }
    return sum;
}

Console.Write("Введите количество чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(length);
int count = Count (arr);

Console.Write("В массиве ");
PrintArray(arr);
Console.WriteLine($" количество чисел больше нуля равно {count}");