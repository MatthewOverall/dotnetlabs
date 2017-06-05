using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02.Runner
{
    public class Store
    {
        public string Name { get; }
        private readonly List<Item> _items = new List<Item>();

        public Store(string name)
        {
            Name = name;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public Item GetItemByName(string name)
        {
            foreach (var item in _items)
            {
                if (item.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        public void PurchaseItem(string name, Inventory inventory)
        {
            var item = GetItemByName(name);
            if (item == null)
            {
                Console.WriteLine("That item doesn't exist.");
            }
            else if (inventory.Cash >= item.Price)
            {
                inventory.Cash -= item.Price;
                inventory.Items.Add(item);
                Console.WriteLine("You purchased [" + item.Name + "] for $" + item.Price);
            }
            else
            {
                Console.WriteLine("You cannot afford this Item.");
            }
        }

        public void Open(Inventory inventory)
        {
            var keepStoreOpen = true;
            while (keepStoreOpen)
            {
                Console.Clear();
                Console.WriteLine("----" + Name + "----");
                
                Console.WriteLine("Name".PadRight(15) + "Price".PadRight(10) + "Description".PadRight(25));
                Console.WriteLine();
                foreach (var item in _items)
                {
                    Console.WriteLine(item.Name.PadRight(15) + item.Price.ToString("C").PadRight(10) + item.Description.PadRight(25));
                }

                Console.WriteLine(); //blank line
                inventory.PrintInventory();
                Console.WriteLine("Type the name of the item you wish to purchase.");

                Console.WriteLine("1. Open Inventory");
                Console.WriteLine("2. Exit Store");
                Console.Write("Input:");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    inventory.Open();
                }
                if (input == "2")
                {
                    keepStoreOpen = false;
                }
                else
                {
                    if (GetItemByName(input) != null)
                    {
                        PurchaseItem(input, inventory);
                    }
                }
            }
        }
    }
}
