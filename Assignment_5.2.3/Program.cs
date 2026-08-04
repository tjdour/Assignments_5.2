//Assignment 5.2.3
//Write a program in C# Sharp to print numbers from n to 1 using recursion.

RecursivePrint(10);
void RecursivePrint(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.Write(n + " ");
    RecursivePrint(n - 1);

    

}