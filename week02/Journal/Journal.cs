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


    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._Date},{entry._Prompt},{entry._Response}");
            }

        }

    }
    public void LoadFromFile(string file)
    {

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry(parts[1], parts[2], parts[0]);

            _entries.Add(entry);
        }
    }
}