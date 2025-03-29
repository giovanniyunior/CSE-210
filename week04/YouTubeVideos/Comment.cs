class Comment
{
	private string _commentText;
	private string _commentBy;

	public Comment(string comment, string createdBy)
	{
		this._commentBy = createdBy;
		this._commentText = comment;
	}
	public void Display()
	{
		Console.WriteLine($"Commenter: {_commentBy}\n{_commentText}");
	}
}