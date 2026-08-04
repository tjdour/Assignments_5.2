//Assignment 5.2.2
//Write a program in C# Sharp to print the first n natural number using recursion.

Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());

RecursivePrintAsc(num);
void RecursivePrintAsc(int n)
{
    if (n == 0)
    {
        return;
    }

    
    RecursivePrintAsc(n - 1);

    Console.Write(n + " ");

}
