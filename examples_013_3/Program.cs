// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string QuarterCordinats(int qarter)
{
    if(qarter == 1) return "x > 0, y > 0";
    if(qarter == 2) return "x < 0, y > 0";
    if(qarter == 3) return "x < 0, y < 0";
    if(qarter == 4) return "x > 0, y < 0";
    else return "Такой четверти нет";
}

Console.Write("Введите номер четверти - ");

int quarter = int.Parse(Console.ReadLine());
Console.WriteLine(QuarterCordinats(quarter));
