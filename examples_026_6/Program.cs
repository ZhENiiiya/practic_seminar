// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

using Common;

int numberA = Get.ReadNumber("Введите длину первой стороны треугольника - ");
int numberB = Get.ReadNumber("Введите длину второй стороны треугольника - ");
int numberC = Get.ReadNumber("Введите длину третьей стороны треугольника - ");

Console.WriteLine(GetTriangle(numberA, numberB, numberC));

bool GetTriangle(int A, int B, int C)
{
    if (A < (B + C) & B < (A + C) & C < (A + B)) return true;
    return false;
}