//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456->6 782->2 918->8

int number = int.Parse(Console.ReadLine());

if ((100 <= number) & (number < 1000))
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Введено не трех значное число. ");
}
