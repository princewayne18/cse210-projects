using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    //we declare a variable with a data type of entry
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
       
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToCsv(string file)
    {
        if (!file.EndsWith(".csv"))
        {
            file += ".csv";
        }
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"\"{entry._Date}\",\"{entry._Prompt}\",\"{entry._Response}\"");
            }

        }

    }
    public void LoadFromCsv(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

        }

    }
}