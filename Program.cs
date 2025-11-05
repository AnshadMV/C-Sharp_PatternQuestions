using System;



class Day02
{

    public static void Main(string[] args)
    {
        Task01.CheckEvenOdd();
        Task01.positivity();
    }
}

class Task01
{
    public static void CheckEvenOdd()
    {
        Console.WriteLine("Enter a Number : ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            if (num > 0)
            {
                Console.WriteLine("Entered number is Even & Positive ");
            }
            else if (num < 0) {
                Console.WriteLine("Entered number is Even & Negative ");
            }
            else
            {
                Console.WriteLine($" Entered number is {num} . it is a neutral number that is neither positive nor negative.");
            }

        }
        else
        {
            if (num > 0)
            {
                Console.WriteLine("Entered number is Odd & Positive ");
            }
            else
            {
                Console.WriteLine("Entered number is Odd & Negative ");
            }
        }


    }

    public static void positivity()
    {
        Console.WriteLine("Hellow ");
    }

}

