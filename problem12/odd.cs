using System;

class odd
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number");
        int number = int.Parse(Console.ReadLine());

        bool istested = true;
        bool isnottested = false;

        if (number >= 20 && number%2 == 1 )
        {
            Console.WriteLine(istested);
        }
        else
        {
            Console.WriteLine(isnottested);
        }
    }
}
