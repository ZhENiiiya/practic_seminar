// Напишите программу, 
// которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12 45 -> 9
int x = 453;

Console.WriteLine(GetSumNumber(x));

int GetSumNumber( int num)
{
    int res = 0;
    if (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    else
    {
        return res;
    }
    return res + GetSumNumber(num);
    
}