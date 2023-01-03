// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = CreateRandomArray(4, 1, 123);
int[] interval = new int[]{10, 99};
PrintArray(array);
Console.WriteLine($"Значений из промежутка [{interval[0]}, {interval[1]}] -> {SearchingInArrayOfIntevalValues(array, interval)}");


int SearchingInArrayOfIntevalValues(int[] array, int[] interval)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((interval[0] <= array[i]) && (array[i] <= interval[1])) result += 1;
    }
    return result;
}


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int [] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}