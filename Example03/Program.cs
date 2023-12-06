// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    int MinSum = 0;
    int temp = 0;
    int index = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        temp = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = temp + matrix[i, j];
        }
        if (i == 0 || temp < MinSum)
        {
            MinSum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка с индексом " + index);
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);