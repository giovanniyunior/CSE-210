class Word
{
	private string _text;
	private bool _isHidden;
	private string _maskedWord;
	public Word(string text)
	{
		_text = text;
	}
	public void Hide()
	{
		_isHidden = true;
		_maskedWord = _text;
		_text = new string('_', _text.Length);

	}
	public void Show()
	{
		_isHidden = false;
		_text = _maskedWord;
	}
	public bool isHidden()
	{
		return _isHidden;
	}
	public string getDisplayText()
	{
		return _text;

	}
}