using System;

class Program
{
    static void Main(string[] args)
    {
		DisplayWelcome();
		String userName = PromptUserName();
		int number = PromptUserNumber();
		int squareNumber = SquareNumber(number);
		DisplayResult(userName,squareNumber);
	}

	static void DisplayWelcome()
	{
		Console.WriteLine("Welcome to the Program!");
	}

	static String PromptUserName()
	{
		Console.WriteLine("Please enter your name:");
		return Console.ReadLine();
	}

	static int PromptUserNumber()
	{
		Console.WriteLine("Please enter your favorite number:");
		return int.Parse(Console.ReadLine());
	}

	static int SquareNumber(int number)
	{
		return number*number;
	}

	static void DisplayResult(String userName, int number)
	{
		Console.WriteLine($"{userName}, the square of your number is {number}");
	}
}