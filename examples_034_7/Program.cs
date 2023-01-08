// Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

try
{
    int m = ReadInt("Введите m - ");
    int n = ReadInt("Введите n - ");

    int[,] array = Create2DArray(m, n);
    int[,] swapArray = SwapArrayElements(array);

    Print2DArray(array);
    Console.WriteLine();
    Print2DArray(swapArray);
    Console.WriteLine();
    Print2DArray(Array(swapArray));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


int[,] SwapArrayElements(int[,] array)
{
    int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0, iArray = arr.GetLength(0) - 1; i < arr.GetLength(0) & iArray >= 0; i++, iArray--)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0 | i == array.GetLength(0) - 1)
            {
                arr[i, j] = array[iArray, j];
            }
            else
            {
                arr[i, j] = array[i, j];
            }
        }
    }

    return arr;
}

int[,] Array(int[,] array)
{
    int[,] a = new int[2, array.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if(i == a.GetLength(0)-1) a[i, j] = array[array.GetLength(0)-1, j];
            else a[i, j] = array[i, j];
        }
    }
    return a;
}



int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
    return array;
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


int ReadInt(string title)
{
    Console.Write(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed) return number;

    throw new Exception("Введены не корректные символы");
}

