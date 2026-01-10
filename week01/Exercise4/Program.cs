using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Xml.Schema;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        {
        List<int> numbers = new List<int>();
        string input;
        Console.Write("Enter a list of numbers, quit by typing in 0.");
        Console.Write("Type in a number: ");
        
        
        
        while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "0")
                {
                    break;
                }
                else if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    
                }
                else
                {
                    Console.WriteLine("This is not correct, please try again.");
                }
                
            }
            int totalSum = numbers.Sum();
            double average = numbers.Average();
            int maxNumber = numbers.Max();
            Console.WriteLine($"The sum is: {totalSum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
    }
}