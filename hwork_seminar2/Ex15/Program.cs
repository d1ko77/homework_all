// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();


Console.WriteLine("Выходной ли день недели?:");
link1:
Console.WriteLine("Введите цифру дня недели от 1 до 7:");
int num = int.Parse(Console.ReadLine()!);

if (num == 6 || num ==7)
{
    Console.WriteLine($"да! {num} - выходной");
}
else if (num < 1 || num >7)
{
    Console.WriteLine("В неделе 7 дней! Введите цифру дня недели заново!");
    goto link1;
}
else
{
    Console.WriteLine($"нет! {num} - рабочий");
}



// Console.Clear();


// Console.WriteLine("Выходной ли день недели?: ");
// Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
// int num = int.Parse(Console.ReadLine()!);



// while (num < 1 || num > 7)
// {
//     Console.WriteLine($"      В неделе 7 дней! Давай заново: ");
//     int num2 = int.Parse(Console.ReadLine()!);

//     num = num2;

// }
// if (num == 6 || num == 7)
// {
//     Console.WriteLine($"да! {num} день выходной");
// }
// else
// {
//     Console.WriteLine($"нет! {num} день рабочий");
// }