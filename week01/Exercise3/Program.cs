using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine (i);
            }

            Console.Write("Guess the magic number: ");
            string guess = Console.ReadLine();
            int Cardinal = int.Parse(guess);



            if (number == Cardinal)
            {
                Console.WriteLine("That is correct!");
            }

            else if (number != Cardinal)
            {
                Console.WriteLine("Wrong number. Guess again: ");
            }
        }

    }
}