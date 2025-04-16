public class ChecklistGoal : Goal
{
	public int _amountCompleted;
	public int _target;
	public int _points;
	private int _bonus; 
	public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
	{
		_target = target;
		_bonus = bonus;
		_type = "ChecklistGoal";
	}
	public override void RecordEvent()
	{
		_amountCompleted += 1;
		if(_amountCompleted == _target)
		{
			_points += _bonus;
		}
		
	}
	public override bool IsComplete()
	{
		return _amountCompleted == _target;
	}
	public override string GetStringRepresentation()
	{
		return "";
	}
	public override string GetDetailsString()
	{
		return _shortName +" ("+_description+") -- Curently completed: "+_amountCompleted+"/"+_target;
	}
}