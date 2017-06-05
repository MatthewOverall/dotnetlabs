using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            var inventory = new Inventory { Cash = 150 };

            var woodenPick = new Item("Wooden Pick", "It can't break much, but at least it works.", 20);
            var copperPick = new Item("Stone Pick", "It is better than wood, but hard to swing.", 30);
            var bronzePick = new Item("Iron Pick", "Much better than stone, and isn't too heavy.", 50);
            var diamondPick = new Item("Diamond Pick", "The best pick you could ask for, but very expensive", 100);

            var store = new Store("Cranky's PickAxe Store");
            store.AddItem(woodenPick);
            store.AddItem(copperPick);
            store.AddItem(bronzePick);
            store.AddItem(diamondPick);

            var keepRunning = true;

            while (keepRunning)
            {
                Console.Clear(); // clear the console after each loop.
                Console.WriteLine("1. Open Inventory");
                Console.WriteLine("2. Enter Store");
                Console.WriteLine("3. Exit Application");
                Console.WriteLine();
                Console.Write("Input:");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    inventory.Open();
                }
                if (input == "2")
                {
                    store.Open(inventory);
                }

                if (input == "3")
                {
                    keepRunning = false;
                }
            }
        }

        static void Test()
        {
            int startingCash = 50;
            var inventory = new Inventory { Cash = startingCash };

            var cheapItem = new Item("Cheap Item", "Cheap!", 1);
            var expensiveItem = new Item("Expensive Item", "Expensive!", 10000);

            var store = new Store("Test Store");
            store.AddItem(cheapItem);
            store.AddItem(expensiveItem);

            Debug.Assert(store.GetItemByName(cheapItem.Name) == cheapItem, "Loop through all items and return the first one with a matching name.");
            Debug.Assert(store.GetItemByName(expensiveItem.Name) == expensiveItem);

            Debug.Assert(inventory.Items.Count == 0, "ensure inventory `List<Item> Items` is initialized!");

            store.PurchaseItem(cheapItem.Name, inventory);
            Debug.Assert(inventory.Items[0] == cheapItem, "cheap item should be in inventory");
            Debug.Assert(inventory.Cash == startingCash - cheapItem.Price);

            store.PurchaseItem(expensiveItem.Name, inventory);
            Debug.Assert(inventory.Items.Count == 1, "I could never afford this item.");

            Debug.Assert(store.GetItemByName(expensiveItem.Name.ToUpper()) == expensiveItem, "Can you make GetItemByName case insensitive?");
        }
    }
}
