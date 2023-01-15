// Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень 
// B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35)
// A = 2; B = 3 -> 8

int a = 2;
int b = 3;

Console.WriteLine(Exponentiation(a, b));

int Exponentiation(int a, int b)
{
    int res = 1;
    if (b > 0)
    {
        res *= a;
        b--;
    }
    else
    {
        return res;
    }
    return res * Exponentiation(a, b);
}

