
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 3]
int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] tmp = new int[array.Length];
Array.Copy(array, tmp, array.Length);

Reverse(array);
PrintArray(array);
PrintArray(ReverseV2(array));
PrintArray(tmp);

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int[] ReverseV2(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

void Reverse(int[] array)
{
    int tmp;
    for (var i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;

    }
}