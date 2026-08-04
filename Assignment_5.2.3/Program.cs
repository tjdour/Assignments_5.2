//Assignment 5.2.3
//Write a program in C# Sharp to print numbers from n to 1 using recursion.

Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());

RecursivePrintDesc(num);

void RecursivePrintDesc(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.Write(n + " ");
    RecursivePrintDesc(n - 1);

}