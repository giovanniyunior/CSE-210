using System;

class Resume
{
	public String _name;
	public List<Job> _Job = new List<Job>();
 
	public void Display()
	{
		Console.WriteLine($"Name: {_name}");
		Console.WriteLine("Jobs:");
		foreach(Job j in _Job)
		{
			j.Display();
		}

	}
}