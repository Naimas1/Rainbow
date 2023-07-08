using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    class BackpackItem
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public BackpackItem(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }

    class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double Capacity { get; set; }
        public List<BackpackItem> Contents { get; set; }

        public Backpack(string color, string brand, string manufacturer, string fabric, double weight, double capacity)
        {
            Color = color;
            Brand = brand;
            Manufacturer = manufacturer;
            Fabric = fabric;
            Weight = weight;
            Capacity = capacity;
            Contents = new List<BackpackItem>();
        }

        public void AddItem(BackpackItem item)
        {
            if (item.Volume <= GetAvailableVolume())
            {
                Contents.Add(item);
                Console.WriteLine($"Added item '{item.Name}' to the backpack.");
            }
            else
            {
                Console.WriteLine($"Not enough space in the backpack to add item '{item.Name}'.");
            }
        }

        public void RemoveItem(BackpackItem item)
        {
            if (Contents.Contains(item))
            {
                Contents.Remove(item);
                Console.WriteLine($"Removed item '{item.Name}' from the backpack.");
            }
            else
            {
                Console.WriteLine($"Item '{item.Name}' not found in the backpack.");
            }
        }

        public double GetAvailableVolume()
        {
            double usedVolume = 0;
            foreach (var item in Contents)
            {
                usedVolume += item.Volume;
            }
            return Capacity - usedVolume;
        }
    }

    class Programs
    {
        static void Main()
        {
            Backpack backpack = new Backpack("Blue", "ABC", "XYZ Company", "Nylon", 1.5, 10);

            Console.WriteLine($"Color: {backpack.Color}");
            Console.WriteLine($"Brand: {backpack.Brand}");
            Console.WriteLine($"Manufacturer: {backpack.Manufacturer}");
            Console.WriteLine($"Fabric: {backpack.Fabric}");
            Console.WriteLine($"Weight: {backpack.Weight} kg");
            Console.WriteLine($"Capacity: {backpack.Capacity} L");

            Console.WriteLine("\nAdding items to the backpack:");
            BackpackItem item1 = new BackpackItem("Water bottle", 0.5);
            backpack.AddItem(item1);

            BackpackItem item2 = new BackpackItem("Laptop", 2.0);
            backpack.AddItem(item2);

            Console.WriteLine("\nRemoving items from the backpack:");
            backpack.RemoveItem(item1);
            backpack.RemoveItem(item2);

            Console.WriteLine("\nAdding items that exceed the capacity of the backpack:");
            BackpackItem item3 = new BackpackItem("Textbooks", 8.0);
            backpack.AddItem(item3);

            BackpackItem item4 = new BackpackItem("Camera", 2.0);
            backpack.AddItem(item4);
        }
    }
}
