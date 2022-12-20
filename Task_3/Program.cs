// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int m = EnterNumber("Введите количество строк 1 матрицы: ");
int n = EnterNumber("Введите количество столбцов 1 матрицы: ");
int p = EnterNumber("Введите количество строк 2 матрицы: ");
int t = EnterNumber("Введите количество столбцов 2 матрицы: ");

int[,] firstMatrix = CreateRandomArray(m, n, 1, 5);
int[,] secondMatrix = CreateRandomArray(p, t, 1, 5);
System.Console.WriteLine();
PrintArray(firstMatrix);
System.Console.WriteLine();
PrintArray(secondMatrix);
System.Console.WriteLine();
if(m!=t)
{
    System.Console.WriteLine("Такие матрицы перемножать нельзя!");
    return;
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMatrix)
{
int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(MultiplyMatrix(firstMatrix, secondMatrix));
