/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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

void MultiplyMatrix(int[,] firstmatrix, int[,] secomdmatrix, int[,] resultmatrix)
{
    for (int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstmatrix.GetLength(1); k++)
            {
                sum = sum + firstmatrix[i, k] * secomdmatrix[k, j];
            }
            resultmatrix[i, j] = sum;
        }
    }
}

Console.WriteLine("Введите число строк матрицы:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы:");
int n = int.Parse(Console.ReadLine());
int[,] firstmatrix = InitMatrix(m, n);
Console.WriteLine($"Первая матрица размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(firstmatrix);

int[,] secondmatrix = InitMatrix(m, n);
Console.WriteLine($"Вторая матрица размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(secondmatrix);

int[,] thirdmatrix = new int[m, n];
MultiplyMatrix(firstmatrix, secondmatrix, thirdmatrix);
Console.WriteLine($"Произведение первой и второй матрицы:");
Console.WriteLine();
PrintMatrix(thirdmatrix);
