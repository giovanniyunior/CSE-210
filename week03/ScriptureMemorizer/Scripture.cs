class Scripture
{
	private Reference _reference;
	private List<Word> _words = new List<Word>();

	public Scripture(Reference reference, string text)
	{
		_reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
	}
	public void hideRandomWords(int numberToHide)
	{
		int wordsHidden = 0;
		while(wordsHidden <  numberToHide)
		{
			Random randomGenerator = new Random();
			int number = randomGenerator.Next(0, _words.Count);
			if(!_words[number].isHidden()){
				_words[number].Hide();
				wordsHidden ++;
			}
			
		}
		Console.Clear();
		Console.Write(getDisplayText()+"\n");
		
	}
	public void ShowRandomWords(int numberToHide)
	{
		int wordsHidden = 0;
		while(wordsHidden <  numberToHide)
		{
			Random randomGenerator = new Random();
			int number = randomGenerator.Next(0, _words.Count);
			if(_words[number].isHidden()){
				_words[number].Show();
				wordsHidden ++;
			}
			
		}
		Console.Clear();
		Console.Write(getDisplayText()+"\n");
		
	}
	public string getDisplayText()
	{
        return _reference.getDisplayText() +" "+ string.Join(" ", _words.Select(w => w.getDisplayText()));
	}
	public bool IsCompletelyHidden()
	{
		return _words.All(w => w.isHidden());

	}
}