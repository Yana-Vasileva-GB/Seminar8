// Домашняя задача 58.
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.Write("Введите число строк матрицы A - ");
int sizeA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы А - ");
int sizeA2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк матрицы B -  ");
int sizeB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы B - ");
int sizeB2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[sizeA1, sizeA2];
int[,] matrixB = new int[sizeB1, sizeB2];
int size1 = sizeA1;
int size2 = sizeB2;

if (sizeA2 == sizeB1)
{
    Array(matrixA);
    Array(matrixB);
    int[,] matrixC = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size2; k++)
            {
               matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Матрица 1:");
    PrintArray(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица 2:");
    PrintArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Результат умножения матриц:");
    PrintArray(matrixC);
}
else 
Console.WriteLine("Умножение матриц невозможно!");