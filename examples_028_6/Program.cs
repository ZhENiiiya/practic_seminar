// Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int num = 10;
Console.Write($"{num} -> ");
PrintArray(Fibonacci(num));

double[] Fibonacci(int n)
{
    double[] fibonacciNum = new double[n];
    fibonacciNum[0] = 0;
    fibonacciNum[1] = 1;
    for (int i = 2; i < fibonacciNum.Length; i++)
    {
        fibonacciNum[i] = fibonacciNum[i - 1] + fibonacciNum[i - 2];
    
    }
    return fibonacciNum;
}

void PrintArray(double[] array)
{
    Console.WriteLine(string.Join(", ", array));
}
