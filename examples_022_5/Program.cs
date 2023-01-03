// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int searchNumber1 = 4;
int searchNumber2 = 3;
int[] array = new int []{6, 7, 19, 345, 3};

Console.WriteLine($"{searchNumber1}; массив {PrintArray(array)} -> " 
                + $"{SearchNumberInArray(array, searchNumber1)}");


Console.WriteLine($"{searchNumber2}; массив {PrintArray(array)} -> " 
                + $"{SearchNumberInArray(array, searchNumber2)}");

string SearchNumberInArray(int[] array, int searchNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNumber) return "Да";
    }
    return "Нет";
}


string PrintArray(int[] array)
{
    return $"[{string.Join(", ", array)}]";
}