public class ListingActivity : Activity
{
	private int _count;
	private List<string> _promps = new List<string>();
	private List<string> _userList = new List<string>();

	public ListingActivity()
	{
		_name = "Listing Activity";
		_description = "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.";

		// Set other values here that are unique to the Reflecting Activity
	}
	public void Run()
	{
		Console.Clear();

		DataFactory();
		DisplayStartingMessage();
		Console.Write("How long, in seconds, would you like for your session?");
		_duration = int.Parse(Console.ReadLine());
		Console.Clear();

		
		Console.WriteLine("Get ready...\n");
		ShowSpinner(3);
		DisplayPrompt();
		Console.Write("You may bigin in: ");
		ShowCountDown(5);
		Console.Write("\n");
		DateTime startDate = DateTime.Now;
		DateTime endTime = startDate.AddSeconds(_duration);

		while (DateTime.Now < endTime)
		{
			Console.Write(">");
			_userList.Add(Console.ReadLine());
		}
		
		DisplayListFromUser();
		Console.WriteLine("\nWell done!!\n");
		ShowSpinner(4);

		DisplayEndingMessage();
		ShowSpinner(3);


	}
	private void DataFactory()
	{
		_promps.Add("Who are people that you appreciate?");
		_promps.Add("What are personal strengths of yours?");
		_promps.Add("Who are people that you have helped this week?");
		_promps.Add("When have you felt the Holy Ghost this month?");
		_promps.Add("Who are some of your personal heroes?");

	}
	private String GetRandomPrompt()
	{
		Random randomGenerator = new Random();
		int number = randomGenerator.Next(0, _promps.Count);
		return _promps[number];
	}
	private void DisplayListFromUser()
	{
		_count = _userList.Count;
		Console.WriteLine($"You listed {_count} items.\n");
	}
	private void DisplayPrompt()
	{
		Console.WriteLine($"--- {GetRandomPrompt()} --- \n");
	}
}