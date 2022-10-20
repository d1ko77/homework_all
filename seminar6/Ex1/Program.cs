
int[] Fib(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] array = Fib(5);
Console.WriteLine(string.Join(" ", array));


