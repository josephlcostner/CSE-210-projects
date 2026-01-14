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

    static void PromptUserName()
    {
        Console.WriteLine("What is your name? ");
    }

    static void PromptFavoriteNumber(int number)
    {
        Console.Write("What is your favorite number? ");
    }

    static void SquaredNumber(int number)
    {
        int total = number * number;
        
    }

    static void DisplayPersonalMessage()
    {
        Console.WriteLine($"Hello {PromptUserName}, {DisplayWelcome}, the square of {PromptFavoriteNumber} is {SquaredNumber}");
    }
    
}