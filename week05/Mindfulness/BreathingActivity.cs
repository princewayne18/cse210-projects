public class BreathingActivity : Activity
{
   public BreathingActivity(string name, string description, int duration):base(name, description,duration)
    {

    }
    
    public void run()
    {
        DisplayStartingMessage();


        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.Write("\nNow breathe out... ");
            ShowCountDown(4);

            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}