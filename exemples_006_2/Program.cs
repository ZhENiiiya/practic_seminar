//Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает набольшую цифру числа.
//78 -> 8 12 -> 2 85 -> 8

Random random = new Random();

int ranNumber = random.Next(10, 100);

int lastDigit = ranNumber % 10;
int secondDigit = ranNumber / 10;

//double tmp = (double)ranNumber / 10;

//Console.WriteLine(tmp);

Console.WriteLine(ranNumber);

if (lastDigit > secondDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(secondDigit);
}

