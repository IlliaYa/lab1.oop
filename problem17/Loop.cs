using System;
class Loop
{
    static void Main(string[] args)
    {
        int i, factorial = 1;
        Console.WriteLine("input first number");
        int n = int.Parse(Console.ReadLine());
        for( i=1; i<=n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("output: " + factorial);
    }

}