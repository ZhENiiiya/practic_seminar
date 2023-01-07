// Задайте двумерный массив размером MxN, 
// заполненный случайными целыми числами.
// m = 3, n = 4. 1 4 8 19 
// 5 -2 33 -2 77 3 8 1
try
{
    int m = ReadInt("Введите m - ");
    int n = ReadInt("Введите n - ");

    int[,] array = Create2DArray(m, n);

    Print2DArray(array);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
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



int ReadInt(string title)
{
    Console.Write(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed) return number;

    throw new Exception("Введены не корректные символы");
}
























// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int a = 5;
// int b = 2;

// double c = (double)a / (double)b;

// Console.WriteLine(c);


// про Split
/*
string str = "123,234,53,4324";
string[] strS = str.Split(",");

int[] array = new int[strS.Length];

for (int i = 0; i < strS.Length; i++)
{
    array[i] = int.Parse(strS[i]);
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
*/

// про Join
/*
int[] array = new int[] { 1, 23, 56, 75 };

string str = string.Join(",", array);
Console.WriteLine(str);
*/

/*
int[] array = new int[] { -123, -32543, 241341, 546723 };

int[] result = array.Where(number => number > 0).ToArray();

Print(result);

void Print(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}
*/

/*
string[] array = new string[] { "-123", "-3254l3", "2413l41", "546723", "sd", "sad" };

string[] result = array.Where(str => str.Length > 5).ToArray();

Print(result);


List<string> result2 = new List<string>();

for (var i = 0; i < array.Length; i++)
{
    string str = array[i];
    if (str.Contains("1") && str.Length > 5) result2.Add(str);
}

void Print(string[] array)
{
    Console.WriteLine(string.Join(",", array));
}
*/



