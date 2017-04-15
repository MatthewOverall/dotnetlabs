using System;
using System.Collections.Generic;

namespace Lab_01.Runner
{
	public class Program
	{
		static void Main(string[] args)
		{
			var store = new List<string>
			{
				"Pick",
				"Boots",
				"Helmet"
			};

			while (true)
			{
				Console.Clear();
				ListItems(store);
				Console.WriteLine("Type the name of an Item to add to the store.");
				var newItem = Console.ReadLine();
				if (newItem == "q") break;

				if (newItem != "")
				{
					store.Add(newItem);
				}
			}
		}

		private static void Lab1_5()
		{
			//We generate the store... right?
			var store = new List<string>
			{
				"Pick",
				"Boots",
				"Helmet"
			};

			//Now we want to list the items that are in the store.
			//We do that by creating a method... ListItems;
			ListItems(store);
			Console.ReadKey();

			Console.WriteLine("Type the name of an Item to add to the store.");
			var newItem = Console.ReadLine();
			store.Add(newItem);

			ListItems(store);
			Console.ReadKey();

			//OR we do a while loop.
			Console.WriteLine("OR LETS TO A LOOP!");
			while (true)
			{
				ListItems(store);

				Console.WriteLine("Type the name of an Item to add to the store.");
				var newItem2 = Console.ReadLine();
				store.Add(newItem2);

				//UH OH, NEVER ENDING LOOPS!!!!!!!
			}
		}

		static void ListItems(List<string> store)
		{
			Console.WriteLine("Current items in store: ");

			//Notice how store is RED at first. Because the variable is out of scope.
			for (var i = 0; i < store.Count; i++)
			{
				Console.WriteLine(i + ": " + store[i]);
			}
		}


		/// <summary>
		/// Generic lists.
		/// Reading from a console to add an item
		/// Copy paste isn't the best solution.... KEEP THINGS DRY!
		/// </summary>
		private static void Lab1_4()
		{
			var store = new List<string>
			{
				"Pick",
				"Boots",
				"Helmet"
			};

			Console.WriteLine("Current items in store: ");

			for (var i = 0; i < store.Count; i++)
			{
				Console.WriteLine(i + ": " + store[i]);
			}

			Console.ReadLine();

			Console.WriteLine("Type the name of an Item to add to the store.");
			var newItem = Console.ReadLine();
			store.Add(newItem);

			Console.WriteLine("Current items in store: ");
			for (var i = 0; i < store.Count; i++)
			{
				Console.WriteLine(i + ": " + store[i]);
			}

			Console.ReadLine();

			Console.WriteLine("Type the name of an Item to add to the store.");
			var newItem2 = Console.ReadLine();
			store.Add(newItem2);

			Console.WriteLine("Current items in store: ");
			for (var i = 0; i < store.Count; i++)
			{
				Console.WriteLine(i + ": " + store[i]);
			}

			Console.ReadLine();
		}

		/// <summary>
		/// Generic Lists are better than Arrays!
		/// foreach loop.
		/// </summary>
		private static void Lab1_3()
		{
			var store = new List<string>();
			store.Add("Pick");
			store.Add("Boots");
			store.Add("Helmet");


			foreach (var item in store)
			{
				Console.ReadKey();
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}

		/// <summary>
		/// Arrays! BOO
		/// </summary>
		static void Lab1_2()
		{
			var store = new string[3];
			store[0] = "Pick";
			store[1] = "Boots";
			store[2] = "Helmet";

			//debug to here
			Console.ReadLine();

			/*
			 * In .Net we do not really use Arrays like this, because Arrays in reality have a fixed number or items
			 */

			//There is no ADD method!
		}

		/// <summary>
		/// Hello World, Simple Calls
		/// </summary>
		static void Lab1_1()
		{
			Console.WriteLine("Hello World");
			Console.ReadLine();

			var player1 = new Player("");
			player1.Health = 100;
			player1.Name = "Player 1";

			player1.SayHello();
			Console.ReadLine();


			var player2 = new Player("Player 2");
			player2.SayHello();
			Console.ReadLine();

			player2.ChangeName("Mike!");

			Console.ReadLine();

			player2.SayHello();

			Console.ReadLine();
		}
	}
}
