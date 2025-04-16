using System.IO.Pipes;

abstract class Activity
{
	protected decimal _distance;
	protected decimal _speed;
	protected decimal _pace;
	protected DateTime _date;
	protected string _activityName;
	protected int _duration;

	protected Activity(int duration)
	{
		_date = DateTime.Today;
		_duration = duration;
	}

	protected Activity(decimal distance, decimal speed, decimal pace)
	{
		_distance = distance;
		_speed = speed;
		_pace = pace;
	}

	public virtual string GetSummary()
	{
		GetDistance();
		GetSpeed();
		GetPace();
		return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min): " +
					   $"Distance {GetDistance():0.00} km, Speed {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
	}
	public abstract decimal GetDistance();
	public abstract decimal GetSpeed();
	public abstract decimal GetPace();


}