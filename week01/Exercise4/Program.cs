using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
		List<int> numbers = new List<int>();
		int numberItem = 1;
		int numberSum;
		int largetsNumber;
		double averageNumber;
		while(numberItem != 0)
		{
			Console.WriteLine("Enter a number");
			numberItem = int.Parse(Console.ReadLine());
			if(numberItem != 0){
				numbers.Add(numberItem);
			}

		}
		numberSum = numbers.Sum();
		averageNumber = numbers.Average();
		largetsNumber = numbers.Max();
		Console.WriteLine($"The sum is: {numberSum}");
		Console.WriteLine($"The average is: {averageNumber}");
		Console.WriteLine($"The largest number is: {largetsNumber}");
		Console.WriteLine( "The sorted list is:");
		numbers.Sort();
		foreach(int n in numbers)
		{
			Console.WriteLine(n);
		}

	}
}