// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

/*
int ReadNum(string s) // Надо доработать метод
{
    Console.Write(s);
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number)){}
    else
    {
        Console.WriteLine("Неверный ввод");
    }
    return number;
}
*/
void NumDivisible(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine(num1 + ", " + num2 + " -> кратно");
    }
    else
    {
        int inDivisible = num1 % num2;
        Console.WriteLine(num1 + ", " + num2 + " ->  не кратно, остаток " + inDivisible);
    }
}

Console.Write("Первое число - ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Второе число - ");
int secondNum = int.Parse(Console.ReadLine());


NumDivisible(firstNum, secondNum);
