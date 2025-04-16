using System.Runtime.CompilerServices;

public class GoalManager
{
	private List<Goal> _goals = new List<Goal>();
	private int _score = 0;

	public GoalManager()
	{
	}
	public void Start()
	{
		Console.Clear();

		int userOption = 0;
		while (userOption != 6)
		{
		Console.WriteLine($"You have {_score} points.\n");
		Console.WriteLine("Menu Options:");
		Console.WriteLine("1. Create New Goal");
		Console.WriteLine("2. List Goals");
		Console.WriteLine("3. Save Goals");
		Console.WriteLine("4. Load Goals");
		Console.WriteLine("5. Record Event");
		Console.WriteLine("6. Quit");
		Console.Write("Select a choice from the menu: ");
		userOption = int.Parse(Console.ReadLine());
		if(userOption == 1)
		{
			CreateGoal();
		}
		else if(userOption == 2)
		{
			ListGoalDetails();
		}
		else if(userOption == 3)
		{
			SaveGoal();
		}
		else if(userOption == 4)
		{
			LoadGoals();
		}
		else if(userOption == 5)
		{
			RecordEvent();
		}
		}
				
	}
	public void DisplayPlayerInfo()
	{

	}
	public void ListGoalNames()
	{
		for (int i = 0; i < _goals.Count; i++)
		{
			Console.WriteLine($"{i}. {_goals[i]._shortName}");
		}
	}
	public void ListGoalDetails()
	{
		for (int i = 0; i < _goals.Count; i++)
		{
			string completed = _goals[i].IsComplete()? "x": " ";
			Console.WriteLine($"{i+1}. [{completed}] { _goals[i].GetDetailsString()}");

		}

	}
	public void CreateGoal()
	{

		Console.WriteLine("\nThe types of Goals are:");
		Console.WriteLine("1. Simple Goal");
		Console.WriteLine("2. Eternal Goal");
		Console.WriteLine("3. Checklist Goal");
		Console.Write("What type f goal do you want to create? ");

		int userOption = int.Parse(Console.ReadLine());
		if(userOption == 1)
		{
			Console.WriteLine("What is the name of your Goal?");
			string goalName = Console.ReadLine();
			Console.WriteLine("What is the description of your Goal?");
			string goalDesc = Console.ReadLine();
			Console.WriteLine("What are the points of your Goal?");
			string goalPoints = Console.ReadLine();

			_goals.Add(new SimpleGoal(goalName,goalDesc,goalPoints));
		}
		else if(userOption == 2)
		{
			Console.WriteLine("What is the name of your Goal?");
			string goalName = Console.ReadLine();
			Console.WriteLine("What is the description of your Goal?");
			string goalDesc = Console.ReadLine();
			Console.WriteLine("What are the points of your Goal?");
			string goalPoints = Console.ReadLine();
			_goals.Add(new EternalGoal(goalName,goalDesc,goalPoints));

		}
		else if(userOption == 3)
		{
			Console.WriteLine("What is the name of your Goal?");
			string goalName = Console.ReadLine();
			Console.WriteLine("What is the description of your Goal?");
			string goalDesc = Console.ReadLine();
			Console.WriteLine("What are the points of your Goal?");
			string goalPoints = Console.ReadLine();
			Console.WriteLine("What are the target of your Goal?");
			int target = int.Parse(Console.ReadLine());
			Console.WriteLine("What is the bonus to acomplish that target?");
			int bonus = int.Parse(Console.ReadLine());
			_goals.Add(new ChecklistGoal(goalName,goalDesc,goalPoints, target, bonus));
		}

	}
	public void RecordEvent()
	{

		ListGoalNames();
		int index = int.Parse(Console.ReadLine());
		_goals[index].RecordEvent();
		_score += int.Parse(_goals[index]._points);
		

	}
	public void SaveGoal()
	{

	}
	public void LoadGoals()
	{

	}
}