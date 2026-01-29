using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

public class Scripture
{
    //we use reference as variable in this class as we want to use the reference
    //we created the empty list of words to store all the words 
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        string[] split = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in split)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + "\n";
        foreach (Word w in _words)
        {
            display += w.GetDisplayText() + " ";
        }
        return display.Trim();

    }
    public bool IsCompletehidden()
    {
       {
            foreach (Word w in _words)
            {
                if (!w.IsHidden())
                    return false;
            }
            return true;
        }
    }
}