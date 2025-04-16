public class SimpleGoal : Goal
{
	public bool _isComplete;
	public SimpleGoal(string name, string description, string points) : base(name, description, points)
	{
		_type = "EternalGoal";

	}
	public override void RecordEvent()
	{
		_isComplete = true;
	}
	public override bool IsComplete()
	{
		return _isComplete;
	}
	public override string GetStringRepresentation()
	{
		return "";
	}
	public override string GetDetailsString()
	{
		return _shortName +" ("+_description+")";
	}
	public void completeGoal(bool isComplete)
	{
		_isComplete = isComplete;
	}
}