// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечетные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] array2D = new int[,] { { 1, 4, 7, 2 },
                              { 5, 9, 2, 3 },
                              { 8, 4, 2, 4 } };

int[,] array2DV2 = SquareOddInArray2D(array2D);

Print2DArray(array2D);
Console.WriteLine();
Print2DArray(array2DV2);

int[,] SquareOddInArray2D(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 != 0) & (j % 2 != 0)) result[i, j] = array[i, j] * array[i, j];
            else result[i,j] = array[i, j];
        }
    }
    return result;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}



