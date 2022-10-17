using System;

class FindN
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("input second number");
        int n = int.Parse(Console.ReadLine());
        float nDigit = (number / (int)Math.Pow(10, n - 1)) % 10;
        if ((number/ (int)Math.Pow(10, n)) == 0)
        {
            Console.WriteLine("output: -");
        }
        else
        {
            Console.WriteLine("output: " + nDigit);
        }
    }
}
