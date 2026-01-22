using System;

public class Entry

{
   //we are declsring the variables so that we can use them
    public string _Prompt;
    public string _Response;
    public string _Date;

    // we create a constructp to hold very important information and also tha it holds a very important information
public Entry(string prompt,  string response, string date )
    {
        _Date = date;
        _Prompt = prompt;
        _Response = response;
    }


public void Display()
    {
        Console.WriteLine($"Date: {_Date} - Prompt: { _Prompt }");
        Console.WriteLine(_Response);
        Console.WriteLine();
    }
}