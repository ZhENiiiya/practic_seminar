// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

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

int num = ReadNumber("Введите число - ");
Console.Write(num + " -> ");

for (int i = 1; i <= num; i++)
{
    Console.Write(i*i + " ");
}