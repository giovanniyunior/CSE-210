class Running : Activity
{
	public Running(int duration, decimal distance) : base(duration)
	{
		_distance = distance;
	}

	public override decimal GetDistance()
	{
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