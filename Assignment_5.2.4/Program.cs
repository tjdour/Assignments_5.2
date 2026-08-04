//Assignment 5.2.4
//Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.

string input = "RADAR";

Console.WriteLine(IsPalRecursive(input, 0, input.Length - 1));

bool IsPalRecursive(string s, int left, int right)
{
    //base case
    if (left >= right)
    {
        return true;
    }

    //action
    if (s[left] != s[right])
    {
        return false;
    }

    //recursive step
    return IsPalRecursive(s, left + 1, right - 1);
}

