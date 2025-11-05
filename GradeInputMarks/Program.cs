using System;

class GradeInputSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int grade = int.Parse(Console.ReadLine());


        if (grade > 90 && grade < 100)
            Console.WriteLine("S grade");
        else if (grade > 80 && grade < 90)
            Console.WriteLine("A grade");
        else if (grade > 70 && grade < 80)
            Console.WriteLine("B grade");
        else if (grade > 60 && grade < 70)
            Console.WriteLine("C grade");
        else if (grade > 50 && grade < 60)
            Console.WriteLine("D grade");
        else if (grade > 40 && grade < 50)
            Console.WriteLine("E grade");
        else if (grade > 0 && grade < 40)
            Console.WriteLine("Student has failed");
        else
        {
            Console.WriteLine("INvalid Marks");
        }





    }

}