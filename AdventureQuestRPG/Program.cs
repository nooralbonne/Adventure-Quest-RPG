using System;

namespace AdventureQuestRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Adventure adventure = new Adventure();
                adventure.Start();

                Console.WriteLine("Adventure complete!");

                // Example usage of item generation
                Item item = ItemGenerator.GenerateRandomItem();

                if (item != null)
                {
                    Console.WriteLine($"Generated item: {item.Name}");
                    Console.WriteLine($"Description: {item.Description}");

                    // If item is a Potion, cast it to Potion to access HealthRestore
                    if (item is Potion potion)
                    {
                        Console.WriteLine($"Health restored: {potion.HealthIncrease}");
                    }
                }
                else
                {
                    Console.WriteLine("Failed to generate item.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void StartBattle(Characters.Player player, Characters.Monster enemy)
        {
            BattleSystem battleSystem = new BattleSystem();

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("player's turn");
                battleSystem.AttackPlayer(player, enemy);

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("player is win in this battle!!");
                    break;
                }

                Console.WriteLine("enemy's turn");
                battleSystem.AttackMonster(enemy, player);

                if (player.Health <= 0)
                {
                    Console.WriteLine("enemy is win in this battle!!");
                    break;
                }
            }
        }
    }
}
