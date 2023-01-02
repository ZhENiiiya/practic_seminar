// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

PrintArray(GetRandomArray(array));


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
        if (i == array.Length-2) Console.Write($"{array[i+1] }");
    }
    Console.Write("]");
}

int[] GetRandomArray(int[] matr)
{
    Random r = new Random();
    for (int i = 0; i < matr.Length; i++)
    {
        
        matr[i] = r.Next(0, 2);
    }
    return matr;
}