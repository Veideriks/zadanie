string[] stringArray = new string[6];

void PrintArray (string [] stringArray)
{
    for (int i = 0; i<stringArray.Length; i++)
        Console.Write($"{stringArray[i]} ");
}

PrintArray (stringArray);