// Напишите программу, которая будет создавать 
// копию заданного массива с помощью
// поэлементного копирования.

int[] array = new int[]{1, 2, 4, 4, 5, 6};

PrintArray(array);
PrintArray(CopyArray(array));

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}
