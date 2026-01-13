using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
    static void DisplayWelcome(string DisplayWelcome)
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
    }

    static int PromptFavoriteNumber(int number)
    {
        Console.Write("What is your favorite number? ");
    }

    static int SquaredNumber(int number)
    {
        int total = number * number;
        return total;
    }

    static string DisplayPersonalMessage()
    {
        Console.WriteLine($"Hello {PromptUserName}, the square of your favorite number is {SquaredNumber}");
        
    }
        
}