using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(String text)
    {
        //this stores only one word from the text 
        _text = text;

        //this variable checks if the word is hidden
        //in this case its starts as not hidden
        _isHidden = false;
    }

    public void Hide()
    {
        //now this method hides the word inside the _text 
        //this also say if the dont show the letters 
        _isHidden = true;
    }

    public void Show()
    {
        //when we are showing the word 
        //the text reveals the word
        _isHidden = false;
    }

    public bool IsHidden()
    {
        //this is used by other classes especial the class scripture
        //that is the point were encapsulation is recognised
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hidden = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hidden += "_";
            }
            return hidden;
        }
        else
        {
            return _text;
        }
    }


}