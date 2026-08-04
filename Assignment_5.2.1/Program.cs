Console.WriteLine("Enter a string:"); 
string s = Console.ReadLine();

Console.WriteLine(LastWordLength(s));

int LastWordLength(string s)
{
    int index = s.Length - 1;
    int length = 0;

    
    while (index >= 0 && s[index] == ' ')
    {
        index--;
    }

    
    while (index >= 0 && s[index] != ' ')
    {
        length++;
        index--;
    }

    return length;
}


