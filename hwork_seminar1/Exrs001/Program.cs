//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите 1 число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 число: ");
int numberB = int.Parse(Console.ReadLine()!);


if (numberA > numberB)
{
   Console.WriteLine($"Наибольшее число: {numberA}, наименьшее число: {numberB}");
}
else 
{
    Console.WriteLine($"Наибольшее число: {numberB}, наименьшее число: {numberA}");
}
