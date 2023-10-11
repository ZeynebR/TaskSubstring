string Name = "Zeynab";
string Name2 = "Ahad";

Console.WriteLine(substring(0,4,Name));
Console.WriteLine(  substring(0,2, Name2 ));



string substring(int startindex, int length, string name)
{
    string final = "";

    for (int i = startindex; i < startindex + length; i++)
    {
        if (startindex + length < Name.Length)
        {
            final += name[i];
        }


    }
    if (startindex + length > Name.Length)
    {
        Console.WriteLine("Parameter length is longer than name length");
    }

    return final;
    
} 