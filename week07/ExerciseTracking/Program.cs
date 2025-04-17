using System;

class Program
{
    static void Main(string[] args)
	{
		Console.Clear();
		List<Activity> activities = new List<Activity>();
		activities.Add(new Swimming(30, 50));
		activities.Add(new Cycling(30, 100));
		activities.Add(new Running(30, 30));
		Display(activities);
	}

	private static void Display(List<Activity> activities)
	{
		foreach (var activity in activities)
		{
			Console.WriteLine(activity.GetSummary());
		}
	}
}