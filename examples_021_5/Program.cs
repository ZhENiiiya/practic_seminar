// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[]{-4, -8, 8, 2};

PrintArray(array, ReplacingPositiveWithNegativeAndViceVersa(array));

int[] ReplacingPositiveWithNegativeAndViceVersa(int[] array)
{
    int[] arrayResult = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayResult[i] = -array[i];
    }
    return arrayResult;
}

void PrintArray(int[] array1, int[] array2)
{
    Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");
}