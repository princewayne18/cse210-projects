using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    //the fraction class has three types of constructors

    public Fraction()
    {
        //this is the default that is true with fraction 
        //the top has to be a number while the bottom has to start with 1
        //a number divided by 0 gives out an errpr
        _top = 0;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        //when you input one number this automatical makes it awhole number
        //thus the system automatically converts it to afraction 5/1
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //we create special getters and setters 
    //Get top at first it will get 0 
    public int GetTop()
    {
        return _top;
    }

    //this allows us to change the too from 0 to any number we want 
    public void SetTop(int top)
    {
        _top = top;
    }

    //this gets the bottom which starts at 1 
    public int GetBottom()
    {
        return _bottom;
    }

    //this sets the botom from the default 1 to anynumber above 1
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //this is the method what the class do 
    //the below will show the fraction as string 3/4
    public string GetFraction()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

}