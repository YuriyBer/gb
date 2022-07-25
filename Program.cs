// A program that, from an existing array of strings, forms an array of strings with a length less
// than or equal to three characters.

// Input array
string[] enterOrPresetChoise = { "e", "p" };

int inSize = 4;
string[] presetArr = { "hello", "2", "world", ":-)" };

string[] inStrings;

// Enter or preset
if (EnterChoise("Enter e to enter self array or p for use preset", enterOrPresetChoise) == "e")
{
    // Enter array
    inSize = EnterPositiveNumber("Enter the number of strings");
    inStrings = new string[inSize];
    EnterStringArray(inStrings, "Enter next string");
}
else
{
    // Preset array
    inStrings = presetArr;
}

// Form output array
// outSize = inSize;
int outSize = CalculateOutArraySize(inStrings);
string[] outStrings = new string[outSize];
FormOutArray(inStrings, outStrings);

// Print output array
PrintArr(outStrings);

string EnterChoise(string msg, string[] correctValues)
{
    string str;
    Console.Write($"{msg}: ");
    while (true)
    {
        str = Console.ReadLine()!.ToLower();
        for (int i = 0; i < correctValues.Length; i++)
        {
            if (str == correctValues[i])
            {
                return str;
            }
        }
        Console.WriteLine("Wrong value, try again!");
    }
}

int EnterPositiveNumber(string msg)
{
    int n;
    Console.Write($"{msg}: ");
    while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
    {
        Console.WriteLine("Wrong number, try again!");
    }
    return n;
}

void EnterStringArray(string[] arr, string msg)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(msg);
        arr[i] = Console.ReadLine()!;
    }
}

int CalculateOutArraySize(string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length < 4)
        {
            n++;
        }
    return n;
}

void FormOutArray(string[] arrIn, string[] arrOut)
{
    int j = 0;
    for (int i = 0; i < arrIn.Length; i++)
    {
        if (arrIn[i].Length < 4)
        {
            arrOut[j] = arrIn[i];
            j++;
        }
    }
}

void PrintArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    if (arr.Length > 0)
    {
        Console.WriteLine($"{arr[arr.Length - 1]}]");
    }
    else
    {
        Console.WriteLine("]");
    }
}
