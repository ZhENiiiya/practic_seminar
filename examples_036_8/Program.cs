// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// 1, 2, 3 4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int x = ReadNumber("Введите число - ");
int y = ReadNumber("Введите число - ");

int[,] array2D = Create2DArray(x, y);
Print2DArray(array2D);
Console.WriteLine();
int[,] arr = GetFrequencyDictionary(array2D);
Print2DArray(arr);


int[,] GetFrequencyDictionary(int[,] array2D)
{
    int[,] frequencyDict = new int[,]{{1,2,3,4,5,6,7,8,9},
                                     {0,0,0,0,0,0,0,0,0}};
    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int k = 0; k < frequencyDict.GetLength(1); k++)
            {
                if (frequencyDict[0, k] == array2D[i,j])
                {
                    frequencyDict[1, k]++;
                }
            }
        }
    }
    return frequencyDict;

}



int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
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