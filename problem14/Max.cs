using System;
class Max
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("input second number");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("input third number");
        int num3 = int.Parse(Console.ReadLine());
        int max;
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write(num1 + " is the greatest among three.\n");
            }
            else
            {
                Console.Write(num3 + " is the greatest among three.\n");
            }
        }
        else if (num2 > num3)
            Console.Write(num2 + " is the greatest among three.\n");
        else
            Console.Write(num3 + " is the greatest among three.\n");
    }
    
}

