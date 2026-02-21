public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);


        Console.Write("\n How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\n Get ready...");
        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {

        Console.WriteLine("\nWell done!");
        ShowSpinner(3);

        Console.WriteLine($"You completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<String> _spinner = new List<string>();
        _spinner.Add("|"); ;
        _spinner.Add("/");
        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);


        int i = 0;

        while (DateTime.Now <endTime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= _spinner.Count)
            {

                i = 0;
            }

        }


    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    } 

}