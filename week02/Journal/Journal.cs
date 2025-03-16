using System;
using System.Collections.Generic;
using System.IO;


/* 
using System;
using System.Collections.Generic;

public class MyJournal
{
    private List<string> entries;

    public MyJournal()
    {
        entries = new List<string>();
    }

    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }

    public void RemoveEntry(int index)
    {
        if (index >= 0 && index < entries.Count)
        {
            entries.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void DisplayEntries()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {entries[i]}");
        }
    }
}
*/

public class Journal
{
    public List<Entry> entryList = new List<Entry>();
    public void AddEntry(Entry anEntry)
    {
        entryList.Add(anEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry i in entryList)
        {
            i.Display();
        }
    }
    

    public static void SaveToFile(List<Entry> entryList , string saveFilename)
    {
        using(StreamWriter writer = new StreamWriter(saveFilename))
        {
            foreach (Entry i in entryList)
            {
                writer.WriteLine($"{i._date} - {i._promptText}\n{i._entryText}");
            }

        }
        
    }
    public static List<Entry> LoadFromFile(string loadFilename)
    {   
        List<Entry> entryLins = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(loadFilename);
        foreach (string line in lines)
        {
           Console.WriteLine(line);      
      }
      return entryLins;
        //StreamReader reader = new StreamReader(filename);
        //while (!reader.EndOfStream)
        //{
        //    string date = reader.ReadLine();
        //    string prompt = reader.ReadLine();
        //    string entry = reader.ReadLine();
        //    Entry newEntry = new Entry();
        //    newEntry._date = date;
        //    newEntry._promptText = prompt;
        //    newEntry._entryText = entry;
        //    _entries.Add(newEntry);
        //}
        //reader.Close();
    }


    /*
    public string _name = "";
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll()
    {
        Console.WriteLine($"Name: {_name}" );
        Console.WriteLine("Entries:");
        foreach (Entry i in _entries)
        {
        //Console.WriteLine($"{_entries[i]._date} - {_entries[i]._promptText}\n{_entries[i]._entryText}");
        Console.WriteLine($"{i._date} - {i._promptText}\n{i._entryText}");
        i.Display();
        }
    }
    */
}