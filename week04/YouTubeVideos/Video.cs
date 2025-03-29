class Video
{
	private string _title;
	private string _author;
	private double _length;
	private List<Comment> _comments = new List<Comment>();

	public Video(string title, string author, double length)
	{
		this._author = author;
		this._length = length;
		this._title = title;
	}
	public void AddComment(Comment c)
	{
		_comments.Add(c);
	}
	public int GetNumberOfComments()
	{
		return _comments.Count();
	}
	public void Display()
	{
		Console.WriteLine($"{_title}\nCreated By: {_author} Duration: {_length}\nNumber of Comments {GetNumberOfComments()}\n");
		foreach (Comment c in _comments)
		{
			c.Display();
		}
	}
}