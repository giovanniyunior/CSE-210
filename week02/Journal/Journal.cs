using System;
using System.IO; 


public class Journal
{
	public List<Entry> _entries = new List<Entry>();
	public String _FileName;
	
	public void AddEntry(Entry newEntry)
	{
		_entries.Add(newEntry);
	}
	public void DisplayAll()
	{
		foreach(Entry ent in _entries)
		{
			ent.Display();
		}	
	}
	public void SaveToFile(String filename)
	{
		if(_entries is [])
		{
			Console.WriteLine("No Entries to save");
			return;
		}
		using (StreamWriter outputFile = new StreamWriter(filename))
		{
			foreach(Entry anEntry in _entries)
			{
				outputFile.WriteLine($"{anEntry._date}~{anEntry._entryText}~{anEntry._promptText}");

			}
		}
	}
	public void LoadFromFile(String filename)
	{
		try
		{
			string[] lines = System.IO.File.ReadAllLines(filename);
			foreach (string line in lines)
			{
				Entry anEntry = new Entry();
				string[] parts = line.Split("~");

				anEntry._date = parts[0];
				anEntry._entryText = parts[1];
				anEntry._promptText = parts[2];
				_entries.Add(anEntry);
				anEntry.Display();
			}

		}
		catch(Exception e)
		{
			Console.WriteLine("Do Not Exist the file Name");
		}

		
	}

}