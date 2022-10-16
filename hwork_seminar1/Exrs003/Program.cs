//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Clear();

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
 

if (numberA % 2 == 0)
{
    Console.WriteLine($"Число: {numberA} четное");
}

else
{
    Console.WriteLine($"Число: {numberA} нечетное");
}