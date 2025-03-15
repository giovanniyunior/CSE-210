using System;

public class PromptGenerator
{
	public List<String> _prompts = new List<String>(); 
 
	public string GetRandomPrompt()
	{
		_prompts.Add("Who was the most interesting person I interacted with today?");
		_prompts.Add("What was the best part of my day?");
		_prompts.Add("How did I see the hand of the Lord in my life today?");
		_prompts.Add("What was the strongest emotion I felt today?");
		_prompts.Add("If I had one thing I could do over today, what would it be?");
		_prompts.Add("What Happend with your child today?");
		_prompts.Add("What did you lear aboud the gaspel today?");

		Random randomGenerator = new Random();
		int number = randomGenerator.Next(1, 7);

		return _prompts[number];
	}
}