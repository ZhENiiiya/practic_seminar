// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

int n = ReadNumber("Введите число - ");
Console.WriteLine($" {n} -> {GetNumberLength(n)}");


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
            Console.WriteLine("Невверный ввод");
        }
    }
}

int GetNumberLength(int num)
{
    int count = 0;
    for (int i = num; i != 0; i = i / 10)
    {
        count++;
    }
    return count;
}
