using System;

namespace AdventureQuestRPG
{
    // Base class for all items
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    // Weapon class
    public class Weapon : Item
    {
        public Weapon(string name, string description)
            : base(name, description)
        {
        }
    }

    // Armor class
    public class Armor : Item
    {
        public Armor(string name, string description)
            : base(name, description)
        {
        }
    }

    // Potion class
        public class Potion : Item
        {
            public int HealthIncrease { get; set; }

            public Potion(string name, string description, int healthIncrease)
                : base(name, description)
            {
                HealthIncrease = healthIncrease;
            }
        }

        // Class to generate random items
        public static class ItemGenerator
    {
        private static Random random = new Random();

        public static Item GenerateRandomItem()
        {
            int itemType = random.Next(0, 3);

            switch (itemType)
            {
                case 0:
                    return new Weapon("Sword", "A sharp blade that increases attack power.");
                case 1:
                    return new Armor("Shield", "A sturdy shield that increases defense.");
                case 2:
                    return new Potion("Health Potion", "A potion that increases health.", 20); 
                default:
                    return null;
            }
        }
    }
}
