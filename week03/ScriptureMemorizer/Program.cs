using System;

class Program
{
    static void Main(string[] args)
    {
		string scriptureText = "Verily I say unto you all: Arise and shine forth, that thy light may be a standard for the nations;";
        Reference refScripture = new Reference("Doctrine and Covenants",115,5);
		Scripture scripture = new Scripture(refScripture, scriptureText);
		Console.Write(scripture.getDisplayText()+ "\n");

        Console.Write("Press enter  to continue or type 'quit' to finish");
		bool exit = false;
		while(exit == false)
		{
			string userText =  Console.ReadLine();
			if(userText == "quit"){
				exit = true;
			}
			scripture.hideRandomWords(5);
			Console.Write("Press enter  to continue or type 'quit' to finish");
			if(scripture.IsCompletelyHidden())
			{
				exit = true;
			}
		}
    
	}
}