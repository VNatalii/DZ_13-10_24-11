// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}  ");
            else Console.Write($"{matrix[i, j],5} ");

        }
        Console.WriteLine(" | ");
    }
    Console.Write("");
}


int MinSumMatrixRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int row = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }

        array[i] = sum;
    }

    int min = array[0];

    for (int i = 1; i < array.Length - 1; i++)
    {
        
        if (array[i] < min)
        {
            min = array[i];
            row = i;
        }


    }

    return (row + 1);

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
if (r == c) Console.WriteLine("Введены не верные параметры матрицы ");
else
{
    int[,] matx = CreateMatrixRndDouble(r, c, a, b);
    PrintMatrix(matx);

    int d = MinSumMatrixRow(matx);
    Console.WriteLine($"строка с наименьшей суммой равна {d} ");
}


