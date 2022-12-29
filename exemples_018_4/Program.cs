// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

using Common;

int num = Get.ReadNumber("Введите число - ");
Console.WriteLine($"{num} -> {GetProductOfNumbers(num)}");

double GetProductOfNumbers(int number)
{
    double res = 1;
    if (num != 0)
    {
        for (int i = 1; i <= number; i++)
        {
            res = i * res;
        }
        return res;
    }
    else return num;
}
