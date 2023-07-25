//Задача 46: Задайте двумерный массив размером mxn,
//заполненный случайными целыми числами.
//m = 3, n = 4.

using System.Globalization;

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите кличество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int[,] GetArray(int rows, int columns)
{
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            res[i, j] = new Random().Next(10, 100);
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