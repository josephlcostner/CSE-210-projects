using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        PromptUserName();
        int number = PromptFavoriteNumber();
        SquaredNumber(number);
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static void PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        Console.ReadLine();
    }

    public static int PromptFavoriteNumber()
    {
        Console.Write("What is your favorite number? ");
        int FavoriteNumber = int.Parse(Console.ReadLine());
        return FavoriteNumber;
    }

    static void SquaredNumber(int number)
    {   int total;
        total = number * number;
        Console.WriteLine(total);
    }

    
    
}