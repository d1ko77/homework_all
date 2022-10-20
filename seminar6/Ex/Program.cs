
string NewMass(int a)
{
    string arr = "";
    while (a > 0)
    {
        arr += (a % 2).ToString();
        a /= 2;
    }
    return arr;
}

int MassRev(string arr)
{
    string rezult = "";

    for (int i = 0; i < arr.Length; i++)
    {
        rezult += arr[arr.Length-1-i];
    }
    return int.Parse(rezult);
}

// int[] remZeros(int[] arrayA)
// {
//     int indZero = -1;

//     for (int i = 0; i < arrayA.Length; i++)
//     {
//         if (arrayA[i] != 0)
//         {
//             indZero = i;
//             break;
//         }
//     }
//     int[] arrayB = new int[arrayA.Length - indZero];

//     for (int i = 0; i < arrayA.Length - indZero; i++)
//     {
//         arrayB[i] = arrayA[indZero + i];
//     }
//     return arrayB;
// }


Console.Clear();
Console.WriteLine("Введите десятичное число: ");
int num = int.Parse(Console.ReadLine()!);

string array = NewMass(num);
int num1 = MassRev(array);
Console.Write($"В двоичном виде: {num1}");

