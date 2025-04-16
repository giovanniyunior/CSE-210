class Cycling : Activity
{
	public Cycling(int duration, decimal speed) : base(duration)
	{
		_speed = speed;
	}

	public override decimal GetDistance()
	{
		_distance = (_speed / 60) * _duration;
		return _distance;
	}

	public override decimal GetPace()
	{
		_pace = (_distance / _duration) * 60;
		return _pace;
	}

	public override decimal GetSpeed()
	{
		return _speed;
	}
}