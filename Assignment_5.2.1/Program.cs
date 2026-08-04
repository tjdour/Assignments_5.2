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







//int LastWordLength(string s)
//{
//    int length = 0;

//    for (int i = s.Length - 1; i >= 0; i--)
//    {
//        if (s[i] == ' ')
//        {
//            // Ignore spaces until we start counting the last word
//            if (length == 0)
//            {
//                continue;
//            }

//            // We already counted the last word
//            break;
//        }

//        length++;
//    }

//    return length;
//}