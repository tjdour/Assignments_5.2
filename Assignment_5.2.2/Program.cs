//Assignment 5.2.2
//Write a program in C# Sharp to print the first n natural number using recursion.

RecursivePrint(10);
void RecursivePrint(int n)
{
    if (n == 0)
    {
        return;
    }

    
    RecursivePrint(n - 1);

    Console.Write(n + " ");

}
