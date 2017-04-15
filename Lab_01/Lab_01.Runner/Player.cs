using System;

namespace Lab_01.Runner
{
	public class Player
	{
		public string Name { get; set; }
		public int Health { get; set; }

		public void SayHello()
		{
			Console.WriteLine("Hello, I am " + Name);
		}

		public Player(string name)
		{
			Name = name;
		}

		public void PrintStatus()
		{
			Console.WriteLine("Player: " + Name);
			Console.WriteLine();
			Console.WriteLine("Current Health: " + Health);
		}

		public void ChangeName(string newName)
		{
			var oldName = Name;
			Name = newName;
			Console.WriteLine(oldName + ", Changed name To: " + newName);
		}
	}
}