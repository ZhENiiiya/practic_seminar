// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int x = ReadNumber("Введите число - ");
int y = ReadNumber("Введите число - ");

int[,] array2D = Create2DArray(x, y);
Print2DArray(array2D);
Console.WriteLine();

if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] arr2D = Array2DRevers(array2D);
    Print2DArray(arr2D);
}
else Console.WriteLine("Массив перевернуть нельзя.");

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


int[,] Array2DRevers(int[,] array2D)
{


    int[,] resultArray = new int[array2D.GetLength(0), array2D.GetLength(1)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            resultArray[i, j] = array2D[j, i];
        }
    }
    return resultArray;
}

int ReadNumber(string s)
{


    while (true)
    {
        Console.Write(s);
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}