using System;
using System.IO;

        // create class journal
        // _entries: List<Entry>
        // AddEntry() : void / ShowEntries() : void / LoadJournalFromFile() : string / SaveJournalToFile() : void

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void ShowEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void LoadJournalFromFile(string filename)
    {
        //check to make sure the file exists
        if (filename.Exists(filename))
        //update the entries list variable
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2]) { delegate = parts[0] });
                }
            }
        }
        else
        {
            Console.WriteLine("File Not Found");
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
        }
    }
}