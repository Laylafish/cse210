using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers. Type 0 when finished. ");

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter Number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
        }

        int count = numbers.Count;
        float average = sum / count;

        Console.WriteLine($"The sum of all the numbers in the list is: {sum}");
        Console.WriteLine($"The average is: {average}");
    }
}