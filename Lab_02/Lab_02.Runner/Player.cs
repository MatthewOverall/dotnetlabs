using System;

namespace Lab_02.Runner
{
	public class Player
	{
		public string Name { get; set; }
		public int Health { get; set; }

		public bool IsDead
		{
			get { return Health <= 0; }
		}

		public decimal Money { get; set; }
	}
}