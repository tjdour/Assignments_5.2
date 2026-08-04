//Assignment 5.2.1
//Given a string s consisting of words and spaces, return the length of the last word in the string.
//A word is a maximal substring consisting of non-space characters only.

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


