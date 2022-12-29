// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] matrix = new int[8];

PrintArray(GetRandomArray(matrix));


void PrintArray(int[] matr)
{
    Console.Write("[");
    for (int i = 0; i < matr.Length-1; i++)
    {
        Console.Write($"{matr[i]}, ");
        if (i == matr.Length-2) Console.Write($"{matr[i+1] }");
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