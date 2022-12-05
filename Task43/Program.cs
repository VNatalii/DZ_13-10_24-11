// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(" , ");
    }
    Console.Write(")");
}


double[] Cross2Lines(double a, double b, double c, double d)
{
    double[] array = new double[2];
    
    double n = (d - b) / (a - c);
    array[0] = Math.Round(n, 1);

    double m = a * array[0] + b;
    array[1] = Math.Round(m, 1);

    return array;
}

Console.Write("Введите коэффициент k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] cross2Lines = Cross2Lines(k1, b1, k2, b2);
PrintArray(cross2Lines);

