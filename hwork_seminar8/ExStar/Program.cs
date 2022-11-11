﻿// Задача "со звездочкой": Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход 
// целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5
// Нельзя использовать встроенные функции библиотеки Math!

// Если число целое, то можно вычитать из числа все нечетные числа по порядку, 
// пока остаток не станет меньше следующего вычитаемого числа или равен нулю, и посчитать 
// количество выполненных действий. Если число не является целым,
//  то таким образом можно узнать только целую часть числа.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int SqrtNum(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i += 2)
    {
        n -= i;
        result++;
    }
    return result;
}

Console.WriteLine($"Целая часть квадратного корня от числа {num}:  {SqrtNum(num)} ");
