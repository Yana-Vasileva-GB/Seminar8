// Домашняя задача 56.
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] arr(int rows, int columns)
{
    int m = new Random().Next(2, 5);
    int[,] matrix = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;
}
int[,] array = arr(0, 0);

int SumRows(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.Write($"Сумма {i + 1} строки = {sum}");
    Console.WriteLine();
    return sum;
}

int minRows = 0;
int minSum = SumRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRows = SumRows(array, i);
    if (minSum > tempSumRows)
    {
        minSum = tempSumRows;
        minRows = i;
    }
}

Console.WriteLine($"\nМинимальная сумма {minSum} в {minRows + 1} строке");