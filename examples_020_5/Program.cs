// Задайте массив из 12 элементов, заполненный случайними 
// числами из промежутка [-9, 9]. Найдите сумму отрицательныйх и
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = CreateRandomArray(12, -9, 9);
PrintArray(array, "Random array");





// Вариант 1
// Console.WriteLine($"Сумма положительных элементов в масиве равна  {GetSumPositiveNumbers(array)}");
// Console.WriteLine($"Сумма отрицательных элементов в масиве равна  {GetSumNegativNumbers(array)}");


// int GetSumPositiveNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sum += array[i];
//     }
//     return sum;
// }

// int GetSumNegativNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0) sum += array[i];
//     }
//     return sum;
// }


// Вариант 2
//PrintArray(GetSumPositiveAndNegative(array), "Суммы положительных и отрицательных элементов массива - ");


// int[] GetSumPositiveAndNegative(int[] array)
// {
//     int[] sumPositivandNegativ = new int[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPositivandNegativ[0] += array[i];
//         if(array[i] < 0) sumPositivandNegativ[1] += array[i];
//     }
//     return sumPositivandNegativ;
// }


// Вариант 3
// (int, int) sumPositivandAndNegativ = GetSumPositiveAndSumNegativeNumbers(array);
// Console.WriteLine(sumPositivandAndNegativ.Item1);
// Console.WriteLine(sumPositivandAndNegativ.Item2);

// (int, int) GetSumPositiveAndSumNegativeNumbers(int[] array)
// {
//     int sumPositiv = 0;
//     int sumNegativ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPositiv += array[i];
//         if(array[i] < 0) sumNegativ += array[i];
//     }
//     return (sumPositiv, sumNegativ);
// }

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int [] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    Console.WriteLine($"{message} - [{string.Join(", ", array)}]");
}