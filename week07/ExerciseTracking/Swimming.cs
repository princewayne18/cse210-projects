public class Swimming : Activity
{
    private int _laps; 

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; 
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min) - Distance: {GetDistance():0.2} km, Speed: {GetSpeed():0.2} kph, Pace: {GetPace():0.2} min per km";
    }
}