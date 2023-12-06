// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 21);
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
    int MinNumber = matrix[0, 0];
    int MinRow = 0;
    int MinCol = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(MinNumber > matrix[i, j])
            {
                MinNumber = matrix[i, j];
                MinRow = i;
                MinCol = j;
            }
        }
    }
    int NewRows = matrix.GetLength(0) - 1;
    int NewCols = matrix.GetLength(1) - 1;
    int[,] NewMatrix = new int[NewRows, NewCols];
    
    int newRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i == MinRow)
        {
            continue;
        }

        int newCol = 0;

        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j == MinCol)
            {
                continue;
            }
            NewMatrix[newRow, newCol] = matrix[i, j];
            newCol++;
        }
        newRow++;
    }
    Console.WriteLine();
    Console.WriteLine("Новая матрица: ");
    PrintMatrix(NewMatrix);
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);