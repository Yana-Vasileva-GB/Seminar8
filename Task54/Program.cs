// Домашняя задача 54.
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк, m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов, n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

void NewArray (int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(21);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray (int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int minPos = 0; minPos<n-1; minPos++)
            if(array[i,minPos]<array[i,minPos+1])
            {
                int temp = array[i,minPos+1];
                array[i,minPos+1] = array[i,minPos];
                array[i,minPos] = temp;
            }
        }
    }
}

NewArray(array);
PrintArray(array);
Console.Write("Массив, отсортированный по убыванию значений строк:");
Console.WriteLine();
SortArray(array);
PrintArray(array);