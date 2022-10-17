using System;

class FindN
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number");
        int number = int.Parse(Console.ReadLine());

        bool istested = true;
        bool isnottested = false;

        if (number%9 == 0 || number % 11 == 0 || number%13==0)
        {
            Console.WriteLine(istested);
        }
        else
        {
            Console.WriteLine(isnottested);
        }
    }
}
