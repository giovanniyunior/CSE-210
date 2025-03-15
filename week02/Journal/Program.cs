using System;

class Program
{
    static void Main(string[] args)
	{
		Journal myJournal = new Journal();
		Console.WriteLine("Welcome to your journal");
		int action = 0;
		while(action != 6)
		{
			getOptions();
			action = int.Parse(Console.ReadLine());
			if (action == 1)
			{
				PromptGenerator prompt = new PromptGenerator();
				String promptText = prompt.GetRandomPrompt();
				Console.WriteLine($"{promptText}");
				String entryText = Console.ReadLine();
				myJournal.AddEntry(createEntry(entryText, promptText));

			}
			if (action == 2)
			{
				myJournal.DisplayAll();

			}
			if (action == 3)
			{
				Console.WriteLine("What is the file Name?");
				String fileName = Console.ReadLine();
				myJournal.LoadFromFile(fileName);

			}
			if (action == 4)
			{
				Console.WriteLine("What is the file Name?");
				String fileName = Console.ReadLine();
				myJournal.SaveToFile(fileName);

			}
			if (action == 5)
			{
		
				myJournal.AddEntry(createOldEntry());

			}
			
		}
		



	}

	private static void getOptions()
	{
		
		Console.WriteLine("Select an option:");
		Console.WriteLine("1. Write");
		Console.WriteLine("2. Display");
		Console.WriteLine("3. Load");
		Console.WriteLine("4. Save");
		Console.WriteLine("5. Write Old Entry");
		Console.WriteLine("6. Quit");
		Console.WriteLine("What would you like to do?");

	}

	static Entry createEntry(String entryText, String entryPrompt)
	{
		Entry anEntry = new Entry();
		DateTime theCurrentTime = DateTime.Now;
		anEntry._date = theCurrentTime.ToShortDateString();
		anEntry._entryText = entryText;
		anEntry._promptText = entryPrompt;
		return anEntry;
	}
	static Entry createOldEntry()
	{
		Entry anEntry = new Entry();
		Console.WriteLine("What is your entry date? (Format: DD/MM/YYYY)"); 
		anEntry._date = Console.ReadLine();
		Console.WriteLine("What is your entry prompt?");
		anEntry._promptText = Console.ReadLine();
		Console.WriteLine("What is your entry?");
		anEntry._entryText = Console.ReadLine();

		return anEntry;
	}
}