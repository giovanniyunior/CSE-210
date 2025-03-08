using System;

class Program
{
    static void Main(string[] args)
    {

		Random randomGenerator = new Random();
		int number = randomGenerator.Next(1, 11);
        Console.WriteLine("What is the magic number?");
		int guessNumber = 0;

		while(guessNumber != number)
		{
			Console.WriteLine("What is your guess?");
			guessNumber = int.Parse(Console.ReadLine());
			if(guessNumber < number)
			{
				Console.WriteLine("Higher");
			}
			else if(guessNumber == number){
				Console.WriteLine("You guessed it!");
			}
			else
			{
				Console.WriteLine("Lower");
			}	
		}

    }
}