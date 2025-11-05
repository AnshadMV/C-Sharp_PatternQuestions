using System;

class LeapYeap
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year : ");
        int year = int.Parse(Console.ReadLine());
        if (year != 0)
        {
            if (year % 4 == 0 && year % 100 != 0 || year%400 == 0 )
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a leap Year");
            }
        }
    }
}
