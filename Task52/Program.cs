// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndDouble(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.Write("");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5} ");

        }
        Console.WriteLine(" | ");
    }
    Console.Write("");
}

double[] ArithmeticColums(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double arith = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arith = arith + matrix[i, j];
        }

        array[j] = Math.Round(arith / matrix.GetLength(0), 1);
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.Write(" | ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],5} | ");
        else Console.Write($"{array[i],5} ");
    }
    Console.Write(" | ");
}


Console.Write("Введите количество строк матрицы: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минималное значение элемента массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] matx = CreateMatrixRndDouble(r, c, a, b);
PrintMatrix(matx);

Console.WriteLine();
double[] arithmeticColums = ArithmeticColums(matx);
Console.Write("Среднее арифметическое каждого столбца: ");
Console.WriteLine();
PrintArray(arithmeticColums);
