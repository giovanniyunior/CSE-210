using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿What is your grade percentage?");
		Double gradePercentage = double.Parse(Console.ReadLine());
		string gradeLetter;

		if (gradePercentage >= 90)
		{
			gradeLetter = "A";
		}
		else if (gradePercentage >= 80)
		{
			gradeLetter = "B";
		}
		else if (gradePercentage >= 70)
		{
			gradeLetter = "C";
		}
		else if (gradePercentage >= 60)
		{
			gradeLetter = "D";
		}
		else
		{
			gradeLetter = "F";
		}
		
		
		
		int lastdigit = Convert.ToInt32(gradePercentage) % 10;
		String gradeSign = "";

		if ((gradeLetter == "A" && lastdigit < 3) || gradeLetter!= "F")
		{
			if(lastdigit >= 7)
			{
				gradeSign = "+";
			}
			else if(lastdigit < 3)
			{
				gradeSign = "-";
			}
		}

		Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}");

    }
}