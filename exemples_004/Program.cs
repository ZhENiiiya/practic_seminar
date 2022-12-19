//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

int number = int.Parse(Console.ReadLine());

int revers_num = -number;


if (revers_num < number)
{
    for (revers_num = -number; revers_num <= number; revers_num++)
    {
        Console.Write(revers_num + " ");
    }

}
else
{
    Console.WriteLine("Введенное число не является полажительным");
}
