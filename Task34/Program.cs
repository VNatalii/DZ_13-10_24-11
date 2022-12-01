// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
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

int CountEvenNum(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count = count + 1;

    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(length , 99, 999);
PrintArray(arr);
int countEven = CountEvenNum (arr);
Console.WriteLine("");
Console.WriteLine($"Число четных элементов массива: {countEven}");
