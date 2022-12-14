// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут 
// встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, 
// состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool CheckBracketSeque(string str)
{
     Stack<int> stack = new Stack<int>();
            foreach (char el in str)
            {             // 012345
                int index = "([{)]}".IndexOf(el); // Возвращает индекс с отсчетом от нуля первого вхождения указанного символа
                if (index >= 3)
                {                                                                // stack.Pop() удаляет и возвращает объект, находящийся в начале стека.
                    if (stack.Count == 0 || stack.Pop() != index) return false; // если стек пустой или индекс в начале стеке не равен текущему индексу, то ложь далее стек пустой
                }
                else if (index >= 0) stack.Push(index + 3); // иначе если текущий index >= 0 кладем в стек текущий index + 3
            }                                               // чтобы потом проверить правильность последовательности.
            return stack.Count == 0;
}


Console.Clear();
Console.Write("Введите последовательность скобок {}, (), []: ");
string sign = Console.ReadLine()!;

if (CheckBracketSeque(sign)) Console.WriteLine($"{sign} правильная скобочная последовательность");
else Console.WriteLine($"{sign} неправильная скобочная последовательность");

