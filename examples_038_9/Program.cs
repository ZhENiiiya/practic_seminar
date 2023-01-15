// Задайте значение N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 5;

PrintNum(n, 1);

void PrintNum(int n, int counter)
{
    if (n == 0)
    {}
    else
    {
        Console.WriteLine(counter);
        PrintNum(n-1,counter+1);
    }
}