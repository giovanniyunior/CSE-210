using System;

class Program
{
	static void Main(string[] args)
	{
		List<Video> videos = new List<Video>();
		CreateSampleData(videos);
		DisplayData(videos);

	}

	private static void DisplayData(List<Video> videos)
	{
		foreach (Video v in videos)
		{
			v.Display();
			Console.WriteLine("\n");
		}
	}

	private static void CreateSampleData(List<Video> videos)
	{
		videos.Add(new Video("C# Basics", "John Doe", 45.30));
		videos.Add(new Video("Advanced C#", "Jane Smith", 60.45));
		videos.Add(new Video("Design Patterns in C#", "Mike Johnson", 90.00));

		videos[0].AddComment(new Comment("Great introduction!", "Alice Brown"));
		videos[0].AddComment(new Comment("Very helpful, thanks!", "Bob Green"));
		videos[0].AddComment(new Comment("Can you cover more on classes?", "Charlie Adams"));

		videos[1].AddComment(new Comment("Exactly what I needed!", "Diana Clark"));
		videos[1].AddComment(new Comment("Well explained, great job!", "Ethan White"));
		videos[1].AddComment(new Comment("Please do one on async/await.", "Fiona Black"));

		videos[2].AddComment(new Comment("Loved the examples!", "George King"));
		videos[2].AddComment(new Comment("Could you add more real-world use cases?", "Helen Scott"));
		videos[2].AddComment(new Comment("This is a must-watch for devs!", "Ian Walker"));
	}
}