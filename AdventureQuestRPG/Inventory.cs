using System;
using System.Collections.Generic;

namespace AdventureQuestRPG
{
    public class Inventory
    {
        private List<Item> items;  // List to store items

        public Inventory()
        {
            items = new List<Item>();  // Initialize an empty list
        }

        // Add an item to the inventory
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Added {item.Name} to inventory.");
        }

        // Find an item by its name (case insensitive)
        public Item GetItemByName(string name)
        {
            string lowerName = name.ToLower();  // Convert input name to lower case for case insensitive comparison
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name.ToLower() == lowerName)
                {
                    return items[i];
                }
            }

            Console.WriteLine($"Item '{name}' not found in inventory.");
            return null;
        }

        // Display all items in the inventory
        public void DisplayInventory()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("Inventory:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{items[i].Name}: {items[i].Description}");
            }
        }

    

        // Remove an item from the inventory
        public void RemoveItem(Item item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                Console.WriteLine($"{item.Name} removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{item.Name} not found in inventory.");
            }
        }
    }
}
