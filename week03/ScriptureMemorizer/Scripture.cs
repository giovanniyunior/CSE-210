class Scripture
{
	private Reference _reference;
	private List<Word> _words = new List<Word>();

	public Scripture(Reference reference, string text)
	{
		_reference = reference;
		_words.Add() = text.Split(' ');
	}
	private void hideRandomWords(int numberToHide)
	{
		_words[numberToHide].hide();
	}
	public string getDisplayText()
	{
		return "";
	}
	private bool isCompletelyHidden()
	{
		bool allHidden = true;
		foreach (Word item in _words)
		{
			if(item.isHidden === false){
				allHidden = false;
			}
		}

		return allHidden;
	}
}