// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.Clear();

link1:
Console.WriteLine("Ведите трёхзначное число:");
int num = int.Parse(Console.ReadLine()!);

int a = num;
int digits = 0;


while (a > 0)
{
    digits++;
    a = a / 10;
}
if (digits < 3 || digits > 3)
{
    Console.WriteLine("Введено не трёхзначное число! Введите заново!");
    goto link1;
}
else
{
    int numA = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра из числа {num}, цифра: {numA}");
}


//Console.Clear();

// Console.WriteLine("add num:");
// int num = int.Parse(Console.ReadLine()!);


// if (num >= 99 && num <= 999)
// {
//     int result = (num / 10) % 10;
//     Console.WriteLine($"Вторая цифра из числа {num}, цифра: {result}");
// }
// else
// {
//     while (num < 100 || num > 999)
//     {
//         Console.WriteLine("Ошибка. Число не трехзначное");
//         int num2 = int.Parse(Console.ReadLine()!);
//         num = num2;
//     }


//     int result = (num / 10) % 10;
//     Console.WriteLine($"Вторая цифра из числа {num}, цифра: {result}");
// }
