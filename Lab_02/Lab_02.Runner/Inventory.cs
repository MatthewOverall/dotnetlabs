using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02.Runner
{
    public class Inventory
    {

        public int Cash { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public void RenderInventory()
        {
            Console.WriteLine("----Player Inventory----");
            Console.WriteLine("Name".PadRight(15) + "Description".PadRight(25));
            Console.WriteLine();
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name.PadRight(15) + item.Description.PadRight(25));
            }
            Console.WriteLine("Gold: " + Cash.ToString("C"));
            Console.WriteLine();
        }

        public void Open()
        {
            var keepInventoryOpen = true;
            while (keepInventoryOpen)
            {
                Console.Clear();

                RenderInventory();
                Console.WriteLine(); //blank line
                Console.WriteLine("1. Exit Inventory");
                Console.WriteLine();
                Console.Write("Input:");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    keepInventoryOpen = false;
                }
            }
        }


    }
}