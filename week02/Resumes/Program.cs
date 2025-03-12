using System;

class Program
{
    static void Main(string[] args)
    {
		Job jobItem = new Job();
		jobItem._company = "Accenture";
		jobItem._jobTitle = "Analyst";
		jobItem._startYear = 2024;
		jobItem._endYear = 2025;

		Job jobItem2 = new Job();
		jobItem2._company = "Globant";
		jobItem2._jobTitle = "Salesforce Developer";
		jobItem2._startYear = 2025;
		jobItem2._endYear = 2026;

		Resume cv = new Resume();
		cv._name = "Giovanni Ulloque";
		cv._Job.Add(jobItem);
		cv._Job.Add(jobItem2);

		cv.Display();
    }
}