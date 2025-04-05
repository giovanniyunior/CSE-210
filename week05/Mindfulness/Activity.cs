public class Activity
{
	protected string _name;
	protected string _description;
	protected int _duration;
	public Activity()
	{
		_name = "Breathing";
		_description = "This activity will help you reflect on times ...";
		_duration = 50;

		// Set other values here that are unique to the Reflecting Activity
	}
	public void DisplayStartingMessage()
	{
		Console.WriteLine($"Welcome to the {_name}.\n");
		Console.WriteLine($"{_description}\n");

	}
	public void DisplayEndingMessage()
	{
		Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.\n");

	}
	public void ShowSpinner(int seconds)
	{
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(seconds);
		int i = 0;
		List<string> animation = new List<string>();
		animation.Add("-");
		animation.Add("\\");
		animation.Add("|");
		animation.Add("/");
		while (DateTime.Now < endTime)
		{
			string animationItem = animation[i];
			Console.Write(animationItem);
			Thread.Sleep(500);
			Console.Write("\b \b");
			i++;

			if (i >= animation.Count)
			{
				i = 0;
			}
		}
	}
	public void ShowCountDown(int seconds)
	{
		for (int i = seconds; i > 0; i--)
		{
			Console.Write(i);
			Thread.Sleep(1000);
			Console.Write("\b \b");
		}

	}
}