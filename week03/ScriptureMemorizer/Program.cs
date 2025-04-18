using System;

class Program
{
    static void Main(string[] args)
	{
		Scripture scripture = CreateScripture();
		Console.Write(scripture.getDisplayText() + "\n");

		Console.Write("Press enter  to continue or type 'quit' to finish");
		HideOrShowWords(scripture);

	}

	private static void HideOrShowWords(Scripture scripture)
	{
		bool exit = false;
		while (exit == false)
		{
			string userText = Console.ReadLine();
			if (userText == "quit")
			{
				exit = true;
			}
			if (userText == "show")
			{
				scripture.ShowRandomWords(2);
				Console.WriteLine("Press enter  to continue or type 'quit' to finish \n");
				Console.WriteLine("Type show to restore hidded words\n");
			}
			else
			{
				scripture.hideRandomWords(2);
				Console.WriteLine("Press enter  to continue or type 'quit' to finish \n");
				Console.WriteLine("Type show to restore hidded words\n");
			}


			if (scripture.IsCompletelyHidden())
			{
				exit = true;
			}
		}
	}

	private static Scripture CreateScripture()
	{
		string scriptureText = "Verily I say unto you all: Arise and shine forth, that thy light may be a standard for the nations;";
		Reference refScripture = new Reference("Doctrine and Covenants", 115, 5);
		Scripture scripture = new Scripture(refScripture, scriptureText);
		return scripture;
	}
}