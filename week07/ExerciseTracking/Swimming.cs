class Swimming : Activity
{
	private int _swimmingLaps;
	public Swimming(int duration, int swimmingLaps) : base(duration)
	{
		_activityName = "Swimming";
		_swimmingLaps = swimmingLaps;
	}

	public override decimal GetDistance()
	{
		_distance = (decimal)_swimmingLaps * 50 / 1000;
		return _distance;
	}

	public override decimal GetPace()
	{
		_pace = (_distance / _duration) * 60;
		return _pace;

	}

	public override decimal GetSpeed()
	{
		_speed = _duration / _distance;
		return _speed;

	}
}