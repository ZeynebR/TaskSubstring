string Name = "Hello World";


Console.WriteLine(substring(0,7));


string substring(int startindex, int length)
{
    string final = "";

	for (int i = startindex; i < startindex+length; i++)
	{
        final += Name[i];

    }
    return final;   
} 