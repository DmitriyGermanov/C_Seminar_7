
Console.Clear();
int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] matrix1 = GetArray(rows, columns);
int[,] matrix2 = GetArray(rows, columns);
int[,] matrix3 = FindSumm(matrix1, matrix2);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(matrix3);

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int row, int column)
{
    int[,] res = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i, j] = new Random().Next(10, 100);
        }
    }
    return res;
}


int[,] FindSumm(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array1.GetLength(1)];
    int summ = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}