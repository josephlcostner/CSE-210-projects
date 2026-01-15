public class Prompt
{
    static void Main()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "How did I see thhe hand of the Lord in my life today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do all over again today, what would it be?"
        };

        Random random = Random.Shared;
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }
    public void Display()
    {
        Console.WriteLine($"{List}");
    }
}