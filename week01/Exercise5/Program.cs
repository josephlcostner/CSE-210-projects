using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
    static void DisplayWelcome(string Welcome)
    {
        Console.WriteLine("Welcome to the Program!");
        
    }

    static void PromptUserName(string userName)
    {
        Console.WriteLine("What is your name? ");
    }

    static void PromptFavoriteNumber(int number)
    {
        Console.Write("What is your favorite number? ");
    }

    static int SquaredNumber(int number)
    {
        int total = number * number;
        return total;
    }

    static void DisplayPersonalMessage()
    {
        Console.WriteLine($"Hello {PromptUserName}, the square of your favorite number is {SquaredNumber}");
        
    }
        
}