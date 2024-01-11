using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int scores = int.Parse(gradePercentage);

        string gradeLetter = "";

        if(scores >= 90)
        {
            gradeLetter= "A";
        }

        else if(scores >= 80)
        {
            gradeLetter= "B";
        }

        else if(scores >= 70)
        {
            gradeLetter= "C";
        }

        else if(scores >= 60)
        {
            gradeLetter= "D";
        }

        else
        {
            gradeLetter= "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");

        if(scores >= 70)
        {
            Console.WriteLine("Congratulations! You passed to the next semester");
        }
        else
        {
            Console.WriteLine("Sorry! You will need to try harder next semester");
        }
    }
}