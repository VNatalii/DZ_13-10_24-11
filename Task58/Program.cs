// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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

int [,] MatrixMultiplier(int[,] matrix1, int[,] matrix2 )
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix1[i, j]*matrix2[i, j];
        }

    }
    return matrix;
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
int[,] matx1 = CreateMatrixRndDouble(r, c, a, b);
PrintMatrix(matx1);

Console.WriteLine();
int[,] matx2 = CreateMatrixRndDouble(r, c, a, b);
PrintMatrix(matx2);

Console.WriteLine();
Console.WriteLine("Произведение двух матриц равно");
int[,] matx3 = MatrixMultiplier(matx1, matx2);
PrintMatrix(matx3);
