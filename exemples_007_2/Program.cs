//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46 782 -> 72 918 -> 98

Random random = new Random();
int random_number = random.Next(100, 1000);

int leftNum = random_number / 100;
int rightNum = random_number % 10;

int resultNum = leftNum * 10 + rightNum;

Console.WriteLine(random_number + " -> " + resultNum);
