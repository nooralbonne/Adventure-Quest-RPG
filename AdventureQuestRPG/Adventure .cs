using AdventureQuestRPG.Characters;
using System;

namespace AdventureQuestRPG
{
    public class Adventure
    {
        private Characters.Player player;
        private Inventory inventory;
        private BattleSystem battleSystem;
        private string currentLocation;

        public Adventure()
        {
            player = new Characters.Player();
            inventory = new Inventory();
            battleSystem = new BattleSystem();
            currentLocation = "Town Square";
        }

        public string CurrentLocation => currentLocation; // Add this property

        public void Start()
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.WriteLine($"You are at the {currentLocation}. What would you like to do?");
                Console.WriteLine("1. Move to a new location");
                Console.WriteLine("2. Fight a monster");
                Console.WriteLine("3. View inventory");
                Console.WriteLine("4. Use an item from inventory");
                Console.WriteLine("5. End the game");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PromptMoveToNewLocation(); // Changed to call a separate method for user input
                        break;
                    case "2":
                        FightNextMonster();
                        break;
                    case "3":
                        inventory.DisplayInventory();
                        break;
                    case "4":
                        UseItemFromInventory();
                        break;
                    case "5":
                        gameRunning = false;
                        Console.WriteLine("Game ended. Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void PromptMoveToNewLocation() // Separated user input for better testability
        {
            Console.WriteLine("Choose a new location to move to:");
            Console.WriteLine("1. Forest");
            Console.WriteLine("2. Subway");
            Console.WriteLine("3. Mountain");

            string locationChoice = Console.ReadLine();

            switch (locationChoice)
            {
                case "1":
                    MoveToNewLocation("Forest");
                    break;
                case "2":
                    MoveToNewLocation("Subway");
                    break;
                case "3":
                    MoveToNewLocation("Mountain");
                    break;
                default:
                    Console.WriteLine("Invalid location choice. Please try again.");
                    break;
            }
        }

        public void MoveToNewLocation(string location) // Updated method to change the location
        {
            switch (location)
            {
                case "Forest":
                    currentLocation = "Forest";
                    break;
                case "Subway":
                    currentLocation = "Subway";
                    break;
                case "Mountain":
                    currentLocation = "Mountain";
                    break;
                default:
                    throw new ArgumentException("Invalid location");
            }
            Console.WriteLine($"You have moved to the {currentLocation}.");
        }

        private void FightNextMonster()
        {
            // Reset player's health before starting a new battle
            player.Health = player.MaxHealth;

            Monster monster;
            int randomMonster = new Random().Next(1, 5);

            switch (randomMonster)
            {
                case 1:
                    monster = new Characters.DevilMonster();
                    break;
                case 2:
                    monster = new Characters.VorlaxMonster();
                    break;
                case 3:
                    monster = new Characters.FrankensteinMonster();
                    break;
                case 4:
                    monster = new Characters.BossMonster();
                    break;
                default:
                    monster = new Characters.DevilMonster();
                    break;
            }

            Console.WriteLine($"A wild {monster.Name} appears!");

            bool battleOver = false;

            while (!battleOver)
            {
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use item");
                Console.WriteLine("3. Run away");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        battleSystem.AttackPlayer(player, monster);
                        if (monster.Health <= 0)
                        {
                            Console.WriteLine($"{monster.Name} has been defeated!");
                            Item newItem = battleSystem.GenerateRandomItem();
                            if (newItem != null)
                            {
                                inventory.AddItem(newItem);
                                Console.WriteLine($"You have gained a {newItem.Name}!");
                            }
                            battleOver = true;
                        }
                        else
                        {
                            battleSystem.AttackMonster(monster, player);
                            if (player.Health <= 0)
                            {
                                Console.WriteLine("You have been defeated!");
                                battleOver = true;
                            }
                        }
                        break;
                    case "2":
                        UseItemFromInventory();
                        break;
                    case "3":
                        Console.WriteLine("You run away!");
                        battleOver = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void UseItemFromInventory()
        {
            Console.WriteLine("Enter the name of the item to use:");
            string itemName = Console.ReadLine();
            Item item = inventory.GetItemByName(itemName);

            if (item != null)
            {
                player.UseItem(item);
                inventory.RemoveItem(item);
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
    }
}