// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(" : ");
    }
    Console.Write("]");
}

double CountSum(double[] array)
{
    double sum = 0;
    double min = array[0];
    double max = array[1];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
        
    }

    sum = max - min;

    return sum;
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минималное значение элемента массива: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
double b = Convert.ToDouble(Console.ReadLine());

double[] arr = CreateArrayRndDouble(length , a, b);
PrintArray(arr);
double countSum = CountSum (arr);
Console.WriteLine("");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {countSum}");