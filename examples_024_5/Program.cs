// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arrayOne = new int[] { 1, 2, 3, 4, 5 };
int[] arrayTwo = new int[] { 6, 7, 3, 6 };

PrintArray(arrayOne);
Console.Write(" -> ");
PrintArray(GetProductOfPairsOfArrayElement(arrayOne));

void PrintArray(int[] array)
{
    Console.Write($"[{string.Join(", ", array)}]");
}

int[] GetProductOfPairsOfArrayElement(int[] array)
{
    int[] result;
    if (array.Length % 2 == 0) result = new int[array.Length / 2];
    else result = new int[(array.Length / 2) + 1];

    int count = array.Length - 1;
    for (int i = 0; i < result.Length; i++)
    {
        if (count != i)
        {
            result[i] = array[i] * array[count];
        }
        else
        {
            result[i] = array[i];
            break;
        }
        count--;
    }
    return result;
}

