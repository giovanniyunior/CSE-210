class Fraction
{
	private int _top;
	private int _bottom;

	public void fraction()
	{
		_top = 1;
		_bottom = 1;
	}
	public void fraction(int wholeNumber)
	{
		_top = wholeNumber;
		_bottom = 1;

	}
	public void fraction(int top, int bottom)
	{
		_top = top;
		_bottom = bottom;
	}

	public int getTop()
	{
		return _top;
	}
	public void setTop(int top)
	{
		_top = top;
	}
	public int getBottom()
	{
		return _bottom;
	}
	public void setBottom(int bottom)
	{
		_bottom = bottom;
	}
	public string GetFractionString()
	{
		return _top.ToString() +"/"+_bottom.ToString();
	}
	public double GetDecimalValue()
	{
		return (double) _top/_bottom;
	}

}