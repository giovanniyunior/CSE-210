using System;

class Program
{
	static void Main(string[] args)
	{
		int action = 0;
		while (action != 4)
		{
			Console.Clear();
			getOptions();
			action = int.Parse(Console.ReadLine());
			RunAction(action);

		}

	}

	private static void RunAction(int action)
	{
		if (action == 1)
		{
			BreathingActivity breath = new BreathingActivity();
			breath.Run();
		}
		if (action == 2)
		{
			ReflectingActivity reflecting = new ReflectingActivity();
			reflecting.Run();
		}
		if (action == 3)
		{
			ListingActivity listing = new ListingActivity();
			listing.Run();
		}
	}

	private static void getOptions()
	{
		Console.WriteLine("Menu Options:");
		Console.WriteLine("1. Start breathing activity");
		Console.WriteLine("2. Start reflecting activity");
		Console.WriteLine("3. Start listing activity");
		Console.WriteLine("4. Quit");
		Console.WriteLine("Select a choice from the menu:");
	}
}