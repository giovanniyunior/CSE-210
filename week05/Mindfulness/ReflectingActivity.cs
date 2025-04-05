public class ReflectingActivity : Activity
{
	private List<string> _questions = new List<string>();
	private List<string> _promps = new List<string>();
	public ReflectingActivity()
	{
		_name = "Reflecting";
		_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

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
		Console.WriteLine("Consider the following prompt:\n");

		DisplayPrompt();
		Console.WriteLine("When you have something in mind, press enter to continue.");
		string userText = Console.ReadLine();
		Console.WriteLine("Now ponder on each of the following questions as tehy related to this experience.");
		Console.Write("You may bigin in: ");
		ShowCountDown(5);
		Console.Clear();
		DateTime startDate = DateTime.Now;
		DateTime endTime = startDate.AddSeconds(_duration);

		while (DateTime.Now < endTime)
		{
			DisplayQuestions();
			ShowSpinner(5);
		}
		Console.WriteLine("\nWell done!!\n");
		ShowSpinner(4);

		DisplayEndingMessage();
		ShowSpinner(3);
		

	}

	private void DataFactory()
	{
		_promps.Add("Think of a time when you stood up for someone else.");
		_promps.Add("Think of a time when you did something really difficult.");
		_promps.Add("Think of a time when you helped someone in need.");
		_promps.Add("Think of a time when you did something truly selfless.");
		_questions.Add("Why was this experience meaningful to you?");
		_questions.Add("Have you ever done anything like this before?");
		_questions.Add("How did you get started?");
		_questions.Add("How did you feel when it was complete?");
		_questions.Add("What made this time different than other times when you were not as successful?");
		_questions.Add("What is your favorite thing about this experience?");
		_questions.Add("What could you learn from this experience that applies to other situations?");
		_questions.Add("What did you learn about yourself through this experience?");
		_questions.Add("How can you keep this experience in mind in the future?");
	}

	private string GetRandomPrompt()
	{
		Random randomGenerator = new Random();
		int number = randomGenerator.Next(0, _promps.Count);
		return _promps[number];
	}
	private string GetRandomQuestion()
	{
		Random randomGenerator = new Random();
		int number = randomGenerator.Next(0, _questions.Count);
		return _questions[number];
	}
	private void DisplayPrompt()
	{
		Console.WriteLine($"--- {GetRandomPrompt()} --- \n");
	}
	private void DisplayQuestions()
	{
		Console.WriteLine($"{GetRandomQuestion()}\n");

	}
}