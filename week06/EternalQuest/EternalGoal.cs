public class EternalGoal : Goal
{
	public EternalGoal(string name, string description, string points) : base(name, description, points)
	{
		_type = "EternalGoal";
	}
	public override void RecordEvent()
	{
		
	}
	public override bool IsComplete()
	{
		return false;
	}
	public override string GetStringRepresentation()
	{
		return "";
	}
	public override string GetDetailsString()
	{
		return _shortName +" ("+_description+")";

	}
}