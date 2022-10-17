using System;

class trapezoid
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first side");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("input second side");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("input the height");
        int h = int.Parse(Console.ReadLine());
        double area = (double)((a + b) / 2) * h;

        Console.WriteLine("output: " + (double)area);
    }
}
