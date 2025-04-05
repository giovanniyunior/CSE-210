public class BreathingActivity : Activity
{
	public BreathingActivity()
	{
		_name = "Breathing";
		_description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

		// Set other values here that are unique to the Reflecting Activity
	}
	public void Run()
	{
		Console.Clear();

		DisplayStartingMessage();
		Console.Write("How long, in seconds, would you like for your session?");
		_duration = int.Parse(Console.ReadLine());
		Console.Clear();

		DateTime startDate = DateTime.Now;
		DateTime endTime = startDate.AddSeconds(_duration);
		List<string> breathType = new List<string>();
		breathType.Add("Breathe in...");
		breathType.Add("Breathe out...");
		int i = 0;

		Console.WriteLine("Get ready...\n");
		ShowSpinner(4);

		while (DateTime.Now < endTime)
		{
			Console.Write($"\n{breathType[i]}");
			ShowCountDown(3+i);
			i++;
			if (i == breathType.Count)
			{
				Console.Write("\n");

				i = 0;
			}
		}
		Console.WriteLine("\nWell done!!\n");
		ShowSpinner(4);

		DisplayEndingMessage();
		ShowSpinner(3);

	}
}