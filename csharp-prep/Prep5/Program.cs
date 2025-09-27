using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        SquareNumber(birthYear);
        int age = FindAge(birthYear);
        DisplayResult(name, age);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("What year were you born? ");
        int birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }

    static int SquareNumber(int birthYear)
    {
        int squaredNumber = birthYear * birthYear;
        return squaredNumber;
    }

    static int FindAge(int birthYear)
    {
        DateTime now = DateTime.Now;
        int currentYear = now.Year;
        int age = currentYear - birthYear;
        return age;
    }

    static void DisplayResult(string name, int age)
    {
        Console.WriteLine($"{name}, you will turn {age} this year. ");
    }
}