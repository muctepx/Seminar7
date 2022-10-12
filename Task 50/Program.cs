/*
Задача 50. Напишите программу, которая на вход принимает число и возвращает позицию (i, j) этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 99);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}


int m = GetNumber("Введите кол-во строк матрицы m");
int n = GetNumber("Введите кол-во столбцов матрицы n");
int[,] matrix = InitMatrix(m, n);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
int a = GetNumber("Введите индекс строки:");
int b = GetNumber("Введите индекс столбца:");
if (a > (m - 1) || b > (n - 1))
{
    Console.WriteLine($"Загаданного элемента нет");
}
else
{
    Console.WriteLine($"Загаданный элемент -> {matrix[a, b]}");
}