using System;
using System.IO;
using Prompt;
using Calander;

class Program
{
    static void Main(string[] args)
    {
         int number = int.Parse("");
        
         
        {
           
            Console.WriteLine("Hello World! This is the Journal Project.");

        
            Console.WriteLine("1.Write");  
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Quit");

            Console.WriteLine($"Please input a number from 1-5 to continue with your journal: ");
           
        }
        while (number != 5)
        {
        if (number == 1)
            {
            string randomPrompt = PromptGenerator.GetRandomPrompt();
            Console.WriteLine(randomPrompt);
            Console.ReadKey();
            Console.Write("");
            Console.WriteLine({Calander});
            }
        else if (number == 2)
        {
            List<string> linesToDisplay = new List<string>
            {
                
            };
            foreach(string line in linesToDisplay)
                
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
        }
        else if (number == 3)
        {
            string dataToSave = "";
            File.WriteAllText("Journal.txt", dataToSave);
        
        }
        else if (number == 4)
        {
            if (File.Exists("Journal.txt"))
                {
                    string loadedData = File.ReadAllText("Journal.txt");
                    Console.WriteLine("Loaded:" + loadedData);
                }
        }
        else if (number == 5)
        {
            break;
        }
        else 
            {
           Console.WriteLine("This is not a correct number.") ;
            }
        }
    }

}