class Word
{
	private string _text;
	private bool _isHidden;
	private string _maskedWord;
	public void hide()
	{
		_isHidden = true;
		_maskedWord = new string('_', _text.Length);


	}
	public void show()
	{
		_isHidden = false;
	}
	public bool isHidden()
	{
		return _isHidden;
	}
	private string getDisplayText()
	{
		return "";
	}
}