using System;

class LastDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("input number");
        int n = int.Parse(Console.ReadLine());
        float lastDigit = n;
        while (lastDigit > 10)
        {
            lastDigit = n %10;
        }

        Console.WriteLine("output: " + (float)lastDigit);
    }
}