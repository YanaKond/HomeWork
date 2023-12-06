// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int temp = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = matrix[0,j];
            matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
            matrix[matrix.GetLength(0) - 1, j] = temp;
        }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine("Матрица после изменений: ");
PrintMatrix(matrix);