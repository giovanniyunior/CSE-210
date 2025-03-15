using System;

public class Entry
{
	public String _date;
	public String _entryText;
	public String _promptText;

	
	public void Display()
	{
		Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
		Console.WriteLine($"{_entryText}");
	}
	public string getDataPrompt()
	{
		return $"Date: {_date} - Prompt: {_promptText}";
	}
}