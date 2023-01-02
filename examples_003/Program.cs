//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 5 -> Пятница

Console.Write("Напишите номер от 1 до 7 включительно - ");

int number = int.Parse(Console.ReadLine());

if (number > 0 & number < 8)
{
    if (number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (number == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (number == 3)
    {
        Console.WriteLine("Среда");
    }
    if (number == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (number == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (number == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (number == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}
else
{
    Console.WriteLine(number + " не входит в диапазон от 1 до 7 включительно");
}
