// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5   7     -2    -0,2
// 1    -3,3    8    -9,9
// 8     7,8   -7,1   9

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
            
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} | ");
            else Console.Write($" {matrix[i, j], 5} ");

        }
        Console.WriteLine(" | ");
    }
    Console.Write("");
}


Console.Write("Введите количество строк матрицы: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минималное значение элемента массива: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
double b = Convert.ToDouble(Console.ReadLine());

double[,] matx = CreateMatrixRndDouble(r, c, a, b);
PrintMatrix(matx);
