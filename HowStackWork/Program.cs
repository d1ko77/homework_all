// Creates and initializes a new Stack.
Stack<string> myStack = new Stack<string>();
myStack.Push("The");
myStack.Push("quick");
myStack.Push("brown");
myStack.Push("fox");

// Displays the Stack.
Console.Write("Stack values:");
PrintValues(myStack, '\t');

// Removes an element from the Stack.
Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

// Displays the Stack.
Console.Write("Stack values:");
PrintValues(myStack, '\t');

// Removes another element from the Stack.
Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

// Displays the Stack.
Console.Write("Stack values:");
PrintValues(myStack, '\t');

// Views the first element in the Stack but does not remove it.
Console.WriteLine("(Peek)\t\t{0}", myStack.Peek());

// Displays the Stack.
Console.Write("Stack values:");
PrintValues(myStack, '\t');


void PrintValues(Stack<string> myCollection, char mySeparator)
{
    foreach (Object obj in myCollection)
        Console.Write("{0}{1}", mySeparator, obj);
    Console.WriteLine();
}

