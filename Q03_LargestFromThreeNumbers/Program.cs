using System;

class LargestFromThreeNUmebrs
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a 3 Number: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Console.WriteLine("Your entries are same. Make sure you entered different numbers");
        }
        else
        {
            if (num1 < num2)
            {
                if (num3 < num2)
                {
                    Console.WriteLine($"{num2} is largest");
                }
                else
                {
                    Console.WriteLine($"{num3} is largest");
                }

            }
            else
            {
                if (num1 < num3)
                {
                    Console.WriteLine($"{num3} is largest");
                }
                else
                {
                    Console.WriteLine($"{num1} is largest");
                }

            }
        }
    }
}