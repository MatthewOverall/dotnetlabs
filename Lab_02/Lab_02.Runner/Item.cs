namespace Lab_02.Runner
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Item(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}