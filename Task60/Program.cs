// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



int[,,] CreateMatrixRndDouble(int dim1, int dim2, int dim3)
{


    int[,,] matrix = new int[dim1, dim2, dim3];

    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      
        for (int j = 0; j < matrix.GetLength(1); j++)
           
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                    
                    matrix[i, j, k] = num; 
                    num ++;
                
            }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    Console.Write("");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],5} ({i},{j},{k}) ");
                else Console.Write($"{matrix[i, j, k],5} ({i},{j},{k})");
            }
        }
        Console.WriteLine(" | ");
    }
    Console.Write("");
}




Console.Write("Введите количество в измерении1 матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество в измерении2 матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество в измерении3 матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,,] matx = CreateMatrixRndDouble(a, b, c);
PrintMatrix(matx);



