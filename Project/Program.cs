int GetParticularNumber(string message, int min, int max)
{
    Console.Clear();
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    if (number > min - 1 && number < max + 1)
    {
        Console.Clear();
        return number;
    }
    else
    {
        Console.WriteLine("Error");
        return GetParticularNumber(message, min, max);
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    int i = 0;
    while (i < array.Length - 1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }
    Console.Write(array[array.Length - 1] + "]");
}

string GetString(string message)
{
    Console.WriteLine(message);
    string n = Console.ReadLine();
    return n;
}

void FillArrayFromTerminal(string[] array)
{
    int i = 0;
    int count = 1;
    array[i] = GetString("Введите первое значение");
    Console.Clear();
    i++;
    count++;
    while (i < array.Length - 1)
    {
        array[i] = GetString("Введите следующее значение ");
        Console.Clear();
        i++;
        count++;
    }
    array[array.Length - 1] = GetString("Введите последнее значение");
    Console.Clear();
}

int n = GetParticularNumber("Введите число от 3х до 5ти", 3, 5);
string[] Array = new string[n];
FillArrayFromTerminal(Array);
int m = new Random().Next(0, 4);
if (m == 0)
{
    PrintArray(Array);
    Console.Write(" => ");
    Console.WriteLine("[]");
}
else
{
    string[] Arr = new string[m];
    for (int i = 0; i < m; i++)
    {
        Arr[i] = Array[new Random().Next(0, n)];
    }
    PrintArray(Array);
    Console.Write(" => ");
    PrintArray(Arr);
}
