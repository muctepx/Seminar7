/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//создать массив вещ чисел от 0 до 99

double[,] InitMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 100);
        }
    }

    return matrix;
}


//печатает массив
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:0.0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
int m = GetNumber("Введите кол-во столбцов матрицы");
int n = GetNumber("Введите кол-во строк матрицы");
double[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица вщественных чисел от 0 до 99:");
PrintMatrix(matrix);