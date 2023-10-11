string Name = "Zeynab";


Console.WriteLine(substring(0,4));


string substring(int startindex, int length)
{
    string final = "";

    for (int i = startindex; i < startindex + length; i++)
    {
        if (startindex + length < Name.Length)
        {
            final += Name[i];
        }


    }
    if (startindex + length > Name.Length)
    {
        Console.WriteLine("Parameter length is longer than name length");
    }

    return final;
    
} 