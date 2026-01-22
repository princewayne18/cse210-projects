using System;

public class Job
{
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public string _companyName;


    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}