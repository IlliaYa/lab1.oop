using System;

class Average
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("input second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("input third number");
        int c = int.Parse(Console.ReadLine());
        float avg = (float)(a + b + c)/3;

        Console.WriteLine("output: " + (float)avg);
    }
}
