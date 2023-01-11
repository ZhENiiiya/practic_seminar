// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 14 72
// 59 23
// 84 24
// 52 67
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int m = ReadNumber("Введите число строк - ");
int n = ReadNumber("Введите число столбцов - ");

int[,] array2D = Create2DArray(m, n);

Print2DArray(array2D);
Console.WriteLine();
Console.WriteLine(MinElArray(array2D));
int[,] ntA = NewArray2D(array2D, MinElArray(array2D).i, MinElArray(array2D).j);
Print2DArray(ntA);



int[,] NewArray2D(int[,] arr, int deleteI, int deleteJ)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int newArrI = 0;
    int newArrJ = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (deleteI == i) continue;

        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (deleteJ != j)
            {
                newArr[newArrI, newArrJ] = array2D[i, j];
                newArrJ++;
            }
        }
        newArrI++;
        newArrJ = 0;
    }
    return newArr;

}


(int num, int i, int j) MinElArray(int[,] array2D)
{
    int num = array2D[0, 0];
    int x = 0;
    int y = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (num > array2D[i, j])
            {
                num = array2D[i, j];
                x = i;
                y = j;
            }
        }
    }
    return (num, x, y);
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