using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static void PromptUserName()
    {
        Console.WriteLine("What is your name? ");
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
    }

    static void SquaredNumber()
    {
        return PromptUserNumber * PromptUserNumber;
    }

    static void DisplayPersonalMessage()
    {
        Console.WriteLine($"Hello {PromptUserName}, the square of your favorite number is {SquaredNumber}");
        return DisplayPersonalMessage;
    }
        
}