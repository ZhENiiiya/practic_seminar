// Напишите программу, которая принимает на вход числа (A) и 
// выдает сумму чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36
using Common;

int a = SystemCordinate.GetNumberFromUser();

int sum = GetSumNumbersBetweenOneToNumbers(a);

Console.WriteLine(sum);

int GetSumNumbersBetweenOneToNumbers(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}