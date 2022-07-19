/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

double[,] InitMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(100);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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
void GetPosition(int row, int column, double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && column == j)
                Console.WriteLine($"Число с позицией [{row},{column}] = {matrix[i, j]} ");
        }
    }


}


Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
double[,] matrix = InitMatrix(m, n);
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine("Введите индекс строки искомого числа матрицы:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца искомого числа матрицы:");
int column = int.Parse(Console.ReadLine());
if (row >= 0 && row <= m & column >= 0 && column <= n)
    GetPosition(row, column, matrix);
else
    Console.WriteLine($"Числа с позицией [{row},{column}] в массиве нет ");