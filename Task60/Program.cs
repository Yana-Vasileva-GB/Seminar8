// Домашняя задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int arraySize = 2;
int[,,] array = new int[2, 2, 2];
int[] arr = new int[2 * 2 * 2];
int temp;
for (int i = 0; i < arr.Length; i++)
{
    while (arr[i] == 0)
    {
        temp = new Random().Next(101);
        if (Array.IndexOf(arr, temp, i) == -1)
        {
            arr[i] = temp;
        }
    }
}
int count = 0;
for (int array1 = 0; array1 < arraySize; array1++)
{
    for (int array2 = 0; array2 < arraySize; array2++)
    {
        Console.WriteLine();
        for (int array3 = 0; array3 < arraySize; array3++)
        {
            array[array1, array2, array3] = arr[count];
            count++;
            Console.Write($"{array[array1, array2, array3]} ({array1},{array2},{array3})   ");
        }
        Console.WriteLine();
    }
}