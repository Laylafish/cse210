using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        if (percent >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }
    }
}