using System;
class Sign
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("input second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("input third number");
        int c = int.Parse(Console.ReadLine());
        bool productIs = true;
        bool productNot = false;
        if (a*b*c >= 0)
        {
            Console.Write("input: " + productIs);
        }
        else
            Console.Write("input: " + productNot);

    }

}
