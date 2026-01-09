using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        {
            Console.Write ("Out of 100, what is your grade? ");
            string grade = Console.ReadLine();
            int number = int.Parse(grade);

            if (number <= 100)
            {
                Console.WriteLine("A");
            }
            else if (number <= 89)
            {
                Console.WriteLine("B");
            }
            else if (number <= 79)
            {
                Console.WriteLine("C");
            }
            else if (number <= 69)
            {
                Console.WriteLine("D");
            }
            else if (number <= 59)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("This is not a valid number.");
            }
        }
    }
}