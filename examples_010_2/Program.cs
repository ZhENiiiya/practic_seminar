// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void NumberDivisible(int num)
{
    if (num % 7 == 0 & num % 23 == 0)
    {
        Console.WriteLine(num + " кратно 7 и 23");
        Console.WriteLine(num / 7 + ", " + num / 23);
    }
    else
    {
        Console.WriteLine(num + " не делится одновременно на 7 и 23");
    }
}

Console.Write("Введите число - ");
int num = int.Parse(Console.ReadLine());
NumberDivisible(num);
