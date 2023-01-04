// Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное. 
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int numberDex = 45;

Console.WriteLine($"{numberDex} -> {PrintArray(ConvertDexToBin(numberDex))}");

int[] ConvertDexToBin(int num)
{
    int[] binCode;

    int count = 0;
    for (int i = num; i != 0; i /= 2)
    {
        count++;
    }
    binCode = new int[count];

    for (int i = binCode.Length - 1; i >= 0; i--)
    {
        binCode[i] = num % 2;
        num /= 2;
    }

    return binCode;
}


string PrintArray(int[] array)
{
    return($"{string.Join("", array)}");
}

