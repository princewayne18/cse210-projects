using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breathing.", 0);

                breathing.run();
            }

            else if (choice == 2)
            {
                List<string> prompts = new List<string>()
                {
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you felt the Holy Ghost.",
                    "Think of a time when you overcame a fear."
                };

                List<string> questions = new List<string>()
                {
                    "How did you feel when it was complete?",
                    "What made this time meaningful to you?",
                    "What did you learn from this experience?",
                    "How can you use this experience in the future?"
                };

                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0, prompts, questions);

                reflecting.Run();

            }

            else if (choice == 3)
            {
                List<string> prompts = new List<string>()
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who have you helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };

                ListingActivity listing = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can.", 0, 0, prompts);
                listing.Run();

            }

            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}