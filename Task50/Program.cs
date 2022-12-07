// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

double[,] CreateMatrixRndDouble(int rows, int colums, double min, double max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }

    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.Write("");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}  ");
            else Console.Write($" {matrix[i, j],5} ");

        }
        Console.WriteLine(" | ");
    }
    Console.Write("");
}

void PrintElementMatrix(double[,] matrix, int x, int y)
{
    if (x > matrix.GetLength(0) || y > matrix.GetLength(1)) Console.WriteLine("Такого элемента матрицы не существует");
    else Console.Write($"Элемент матрицы {matrix[(x - 1), (y - 1)]} ");
}


Console.Write("Введите количество строк матрицы: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минималное значение элемента массива: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");
double[,] matx = CreateMatrixRndDouble(r, c, a, b);
PrintMatrix(matx);

Console.WriteLine("");
Console.Write("Укажите строку элемента массива: ");
int rx = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите столбец элемента массива: ");
int cy = Convert.ToInt32(Console.ReadLine());

PrintElementMatrix(matx, rx, cy);

