//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("Число " + numberA + " является квадратом числа " + numberB );
}
else
{
    Console.WriteLine("Число " + numberA + " НЕ является квадратом числа " + numberB );
}