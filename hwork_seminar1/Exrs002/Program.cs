//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите 1 число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 число: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write("Введите 3 число: ");
int numberC = int.Parse(Console.ReadLine()!);


int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}

Console.WriteLine($"Наибольшее число из чисел: {numberA}, {numberB}, {numberC}. Это число: {max}");
   