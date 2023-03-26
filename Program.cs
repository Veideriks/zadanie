string[] stringArray = { "123", "sdasf", "12", "safsavbx", "--9", "njncxvo" };
string[] stringArray2 = {"", "", "", "", "", ""};

void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write($"{stringArray[i]} ");
}

PrintArray(stringArray);
Console.WriteLine();

string str = "null";
for (int i = 0; i < stringArray.Length; i++)
    {
        str = stringArray[i];
        if (str.Length <= 3)
            stringArray2[i]=stringArray[i];
    }
PrintArray(stringArray2);
Console.WriteLine();